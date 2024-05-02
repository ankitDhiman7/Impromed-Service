using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impromed_client.Model
{
    internal class INVOICES
    {
        public Guid OpenInvoiceGuid { get; set; }
        public Guid ClientGuid { get; set; }
        public short PracticeVid { get; set; }
        public Guid InvoiceGuid { get; set; }
        public decimal InvoiceNumber { get; set; }
        public bool Deleted { get; set; }
        public bool Concluded { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid CreateEmployeeGuid { get; set; }
        public string InvoiceLabel { get; set; }
    }
}
