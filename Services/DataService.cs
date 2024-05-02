using System;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace impromed_client.Services
{
    internal class DataService
    {
        public DataService()
        {
            //ServiceName = "DataService";
        }

        public void OnStart()
        {
            Console.WriteLine("DataService is starting...");
            StartBackgroundTask();
        }

        public void OnStop()
        {
            Console.WriteLine("DataService is stopping...");
            StopBackgroundTask();
        }

        private void StartBackgroundTask()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine("Background task is running...");
                    Task.Delay(1000).Wait();
                }
            });
        }

        private void StopBackgroundTask()
        {

        }
    }

    //internal class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        using (var service = new DataService())
    //        {
    //            service.OnStart(args);
    //            Console.WriteLine("Press any key to stop the service...");
    //            Console.ReadKey(true);
    //            service.OnStop();
    //        }
    //    }
    //}
}
