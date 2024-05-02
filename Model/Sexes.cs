using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impromed_client.Model
{
    public class HD_SEX
    {
    public Guid HD_SEX_GUID { get; set; }
        public int HD_ACCT_NUM { get; set; }
        public string SEX { get; set; }
        public bool MALE { get; set; }
        public bool NEUTERED { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public Guid CREATE_USER_GUID { get; set; }
        public Guid CREATE_WORKSTATION_GUID { get; set; }
    }
}
