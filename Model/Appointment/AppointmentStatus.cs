using System;

public class APPT_STATUS
{
    public Guid STATUS_GUID { get; set; }
    public short CATEGORY { get; set; }
    public string NAME { get; set; }
    public string DESCRIPTION { get; set; }
    public string BACK_COLOR { get; set; }
    public string FORE_COLOR { get; set; }
    public short PRACTICE_VID { get; set; }
    public Guid DELETED_GUID { get; set; }
    public bool DELETED { get; set; }
    public DateTime CREATE_DATE_TIME { get; set; }
    public Guid CREATE_OPERATOR_GUID { get; set; }
    public Guid CREATE_WORKSTATION_GUID { get; set; }
    public bool RPT1 { get; set; }
    public bool RPT2 { get; set; }
    public bool RPT3 { get; set; }
    public bool RPT4 { get; set; }
    public bool RPT5 { get; set; }
    public bool RPT6 { get; set; }
    public bool RPT7 { get; set; }
    public bool RPT8 { get; set; }
    public bool RPT9 { get; set; }
}
