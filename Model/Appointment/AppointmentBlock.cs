using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impromed_client.Model
{
    internal class APPT_BLOCKS
    {
        public Guid BlockGuid { get; set; }
        public string Name { get; set; }
        public string BackColor { get; set; }
        public string ForeColor { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsOvernight { get; set; }
        public string Description { get; set; }
        public short PracticeVid { get; set; }
        public Guid DeletedGuid { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid CreateOperatorGuid { get; set; }
        public Guid CreateWorkstationGuid { get; set; }
        public bool IsQuickBlock { get; set; }
    }
}
