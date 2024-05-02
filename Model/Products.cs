using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impromed_client.Model
{
    public class PRODUCTS
    {
        public Guid RevisionGuid { get; set; }
        public Guid ProdGuid { get; set; }
        public Guid ProdmGuid { get; set; }
        public short PracticeVid { get; set; }
        public bool Available { get; set; }
        public short TypeOfProduct { get; set; }
        public bool RestrictEmployees { get; set; }
        public decimal PkgFee { get; set; }
        public bool PriceIsFixed { get; set; }
        public decimal MinPrice { get; set; }
        public decimal DefQty { get; set; }
        public int SpecialDiscountPercent { get; set; }
        public decimal UnitCost { get; set; }
        public decimal HiQty1 { get; set; }
        public decimal HiQty2 { get; set; }
        public decimal HiQty3 { get; set; }
        public decimal HiQty4 { get; set; }
        public decimal HiQty5 { get; set; }
        public decimal IMarkup1 { get; set; }
        public decimal IMarkup2 { get; set; }
        public decimal IMarkup3 { get; set; }
        public decimal IMarkup4 { get; set; }
        public decimal IMarkup5 { get; set; }
        public decimal IPrice1 { get; set; }
        public decimal IPrice2 { get; set; }
        public decimal IPrice3 { get; set; }
        public decimal IPrice4 { get; set; }
        public decimal IPrice5 { get; set; }
        public decimal EMarkup1 { get; set; }
        public decimal EMarkup2 { get; set; }
        public decimal EMarkup3 { get; set; }
        public decimal EMarkup4 { get; set; }
        public decimal EMarkup5 { get; set; }
        public decimal EPrice1 { get; set; }
        public decimal EPrice2 { get; set; }
        public decimal EPrice3 { get; set; }
        public decimal EPrice4 { get; set; }
        public decimal EPrice5 { get; set; }
        public Guid InvmGuid { get; set; }
        public Guid InvGuid { get; set; }
        public decimal InventoryQty { get; set; }
        public short RoundToNearest { get; set; }
        public Guid TaxGuid { get; set; }
        public Guid UsageTaxGuid { get; set; }
        public bool AllowPriceChange { get; set; }
        public bool ModAllowPriceChange { get; set; }
        public bool AllowQtyChange { get; set; }
        public bool ModAllowQtyChange { get; set; }
        public bool AllowNameChange { get; set; }
        public bool ModAllowNameChange { get; set; }
        public bool AllowDiscounts { get; set; }
        public bool AllowZeroPrice { get; set; }
        public bool AllowTaxChange { get; set; }
        public bool ModAllowTaxChange { get; set; }
        public bool AllowTaxExempt { get; set; }
        public Guid ImageGuid { get; set; }
        public string InvoiceNotes { get; set; }
        public string EstimateNotes { get; set; }
        public bool ShowOnInvoice { get; set; }
        public bool ShowOnEstimate { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid CreateUserGuid { get; set; }
        public Guid CreateWorkstationGuid { get; set; }
        public bool Deleted { get; set; }
        public bool ClientNotAllowed { get; set; }
        public short SoapTab { get; set; }
        public bool RestrictSpecies { get; set; }
        public bool RestrictSex { get; set; }
        public decimal PriceOf1 { get; set; }
        public decimal DefHiQty { get; set; }
        public int DefPriority { get; set; }
        public int DefStatus { get; set; }
        public DateTime? DefTimeDue { get; set; }
        public int NumDaysDue { get; set; }
        public string DefComment { get; set; }
        public string Memo { get; set; }
        public bool RestrictAge { get; set; }
        public bool RestrictWeight { get; set; }
        public int StartAge { get; set; }
        public int EndAge { get; set; }
        public float StartWeight { get; set; }
        public float EndWeight { get; set; }
        public Guid TimerGuid { get; set; }
        public bool PromptInvoiceNotes { get; set; }
        public bool PromptEstimateNotes { get; set; }
    }
}
