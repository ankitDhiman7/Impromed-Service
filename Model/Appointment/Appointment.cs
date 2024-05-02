using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impromed_client.Model
{
    public class APPT_M
    {
        [Key]
        public Guid APPT_GUID { get; set; }
        public Guid SERIES_GUID { get; set; }
        public Guid CLUSTER_GUID { get; set; }
        public bool IS_HEADER { get; set; }
        public long CLUSTER_DURATION { get; set; }
        public string SERIES_ID { get; set; }
        public short PRACTICE_VID { get; set; }
        public short TYPE { get; set; }
        public Guid STATUS_GUID { get; set; }
        public DateTime START_TIME { get; set; }
        public DateTime END_TIME { get; set; }
        public Guid RESOURCE_GUID { get; set; }
        public Guid PATIENT_GUID { get; set; }
        public short WHO_FOR { get; set; }
        public Guid WHO_FOR_GUID { get; set; }
        public string NOTES { get; set; }
        public bool HAS_MULTI_DAYS { get; set; }
        public bool IS_RECUR { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public Guid CREATE_OPERATOR_GUID { get; set; }
        public Guid CREATE_WORKSTATION_GUID { get; set; }
        public bool DELETED { get; set; }
        public Guid PARENT_SERIES_GUID { get; set; }
        public bool DELETE_FROM_CLUSTER { get; set; }
        public Guid? SESSION_GUID { get; set; }
    }

    public class AppointmentChange
    {
        public string TableName { get; }
        public string EventType { get; }
        public DateTime Time { get; }
        public string PrimaryKey { get; }

        public AppointmentChange(string tableName, string eventType, DateTime time, string primaryKey = "")
        {
            TableName = tableName;
            EventType = eventType;
            Time = time;
            PrimaryKey = primaryKey;
        }
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class TableNameAttribute : Attribute
    {
        public string Name { get; }

        public TableNameAttribute(string name)
        {
            Name = name;
        }
    }

}
