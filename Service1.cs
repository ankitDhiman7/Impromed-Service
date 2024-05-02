using System;
using System.Collections.Concurrent;
using System.IO;
using System.Reflection;
using System.ServiceProcess;
using System.Threading;
using System.Configuration;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;
using impromed_client.Model;
using TableDependency.SqlClient.Base.Enums;
using ConfigurationManager = System.Configuration.ConfigurationManager;
using impromed_client.Services;

namespace impromed_client
{
    public partial class Service1
    {
        private readonly ConcurrentQueue<AppointmentChange> changeQueue = new ConcurrentQueue<AppointmentChange>();
        private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private readonly Thread serviceThread;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
        public string SPECIES;

        public Service1()
        {
           
            InitializeComponent();
            serviceThread = new Thread(StartServiceLoop);
            serviceThread.Start();
            var service = new DataService();
            {
                service.OnStart();
                service.OnStop();
            };
        }



        //protected override void OnStart(string[] args)
        //{
        //    base.OnStart(args);
        //    serviceThread.Start();
        //}

        //protected override void OnStop()
        //{
        //    cancellationTokenSource.Cancel();
        //    serviceThread.Join();
        //    base.OnStop();
        //}

        public void StartServiceLoop()
        {
            StartTableDependency<APPT_M>(); 
            StartTableDependency<APPT_STATUS>();
            StartTableDependency<HD_SEX>();
            //StartTableDependency<SPECIES>();
            //StartTableDependency<CLIENTS>();
            //StartTableDependency<SPECIES>();
            //StartTableDependency<INVOICES>();
            //StartTableDependency<PRODUCTS>();

            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                ProcessChangeQueue();
                Thread.Sleep(10);
            }
        }

        private void ProcessChangeQueue()
        {
            while (changeQueue.TryDequeue(out AppointmentChange change))
            {
                Console.WriteLine($"Processing change: {change.TableName}, {change.EventType}, {change.Time}, {change.PrimaryKey}");
                WriteLog("Change.txt", "ProcessChangeQueue", $"Change processed: {change.TableName}, {change.EventType}, {change.Time}, {change.PrimaryKey}");
            }
        }

        private void StartTableDependency<T>() where T : class, new()
        {
            try
            {

            string tableName = GetTableName<T>();
            var tableDependency = new SqlTableDependency<T>(connectionString, tableName);
            tableDependency.OnChanged += (sender, e) => TableDependency_Changed(sender, e, tableName);
            tableDependency.OnError += (sender, e) => WriteLog("ErrorLog.txt", $"{tableName}_OnError", $"Table dependency error: {e.Error.Message}");
            tableDependency.Start();
            }
            catch (Exception ex)
            {
                WriteLog("ErrorLog.txt", "{tableName}_OnError", "Table dependency error: {e.Error.Message}" + ex);
            }
        }

        private void TableDependency_Changed<T>(object sender, RecordChangedEventArgs<T> e, string tableName) where T : class, new()
        {
            try
            {
                var changedEntity = e.Entity;

                switch (e.ChangeType)
                {
                    case ChangeType.Insert:
                        EnqueueChange(tableName, "insert", DateTime.Now);
                        WriteLog("Change.txt", $"{tableName}_Changed", $"A change occurred: {e.ChangeType}");
                        break;

                    case ChangeType.Update:
                        EnqueueChange(tableName, "update", DateTime.Now);
                        WriteLog("Change.txt", $"{tableName}_Changed", $"A change occurred: {e.ChangeType}");
                        break;

                    case ChangeType.Delete:
                        EnqueueChange(tableName, "delete", DateTime.Now);
                        WriteLog("Change.txt", $"{tableName}_Changed", $"A change occurred: {e.ChangeType}");
                        break;
                };
            }
            catch (Exception ex)
            {
                WriteLog("ErrorLog.txt", $"{tableName}_Changed", $"An error occurred: {ex.Message}");
            }
        }


        private string GetTableName<T>() where T : class
        {
            var tableNameAttribute = typeof(T).GetCustomAttribute<TableNameAttribute>();
            return tableNameAttribute?.Name ?? typeof(T).Name;
        }

        private void EnqueueChange(string tableName, string eventType, DateTime time)
        {
            AppointmentChange change = new AppointmentChange(tableName, eventType, time);
            changeQueue.Enqueue(change);
            Console.WriteLine(changeQueue);
        }

        private static bool WriteLog(string strFileName, string methodName, string strMessage)
        {
            try
            {
                string logFilePath = $"D:\\LogFolder\\{strFileName}";
                using (FileStream objFilestream = new FileStream(logFilePath, FileMode.Append, FileAccess.Write))
                using (StreamWriter objStreamWriter = new StreamWriter(objFilestream))
                {
                    FileInfo fileInfo = new FileInfo(logFilePath);
                    bool isEmpty = fileInfo.Length == 0;

                    if (isEmpty)
                    {
                        objStreamWriter.WriteLine("| Date       | Time     | Method Name                            | Details                                            |");
                        objStreamWriter.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                    }

                    objStreamWriter.WriteLine($"| {DateTime.Now.ToString("yyyy-MM-dd")} | {DateTime.Now.ToString("HH:mm:ss")} | {methodName,-38} | {strMessage}");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
                return false;
            }
        }
    }
}
