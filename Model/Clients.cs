using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impromed_client.Model
{
    internal class CLIENTS
    {
        public Guid ClientGuid { get; set; }
        public short PracticeVid { get; set; }
        public string ClientAccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseLastName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public Guid CityStateGuid { get; set; }
        public string Zipcode { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string EmailAddress { get; set; }
        public bool Active { get; set; }
        public DateTime? FirstVisit { get; set; }
        public DateTime? LatestVisit { get; set; }
        public decimal TotalSales { get; set; }
        public bool Deleted { get; set; }
        public string Salutation { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid CreateUserGuid { get; set; }
        public Guid CreateWorkstationGuid { get; set; }
        public string MonetaryFlag { get; set; }
        public Guid DiscountGuid { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int TotalVisits { get; set; }
        public Guid ReferralSourceGuid { get; set; }
        public int TotalReferrals { get; set; }
        public Guid ClientTypeGuid { get; set; }
        public Guid? ImageGuid { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string SpouseSocialSecurityNumber { get; set; }
        public Guid PreferredCommMethodGuid { get; set; }
        public string FaxNumber { get; set; }
        public Guid DeletedUniqifyingGuid { get; set; }
        public bool TaxExempt { get; set; }
        public string DriverLicense { get; set; }
        public string SpouseDriverLicense { get; set; }
        public string PreviousAccountId { get; set; }
        public decimal YtdTotalSales { get; set; }
        public int YtdTotalReferrals { get; set; }
        public int YtdTotalVisits { get; set; }
        public string SomeColumn1 { get; set; }
        public string SomeColumn2 { get; set; }
        public string SomeColumn3 { get; set; }
        public string SomeColumn4 { get; set; }
        public string SomeColumn5 { get; set; }
        public string SomeColumn6 { get; set; }
        public string SomeColumn7 { get; set; }
        public string SomeColumn8 { get; set; }
        public bool SomeColumn9 { get; set; }
        public bool SomeColumn10 { get; set; }
        public bool SomeColumn11 { get; set; }
        public bool SomeColumn12 { get; set; }
        public bool SomeColumn13 { get; set; }
        public bool SomeColumn14 { get; set; }
        public bool SomeColumn15 { get; set; }
        public bool SomeColumn16 { get; set; }
        public bool SomeColumn17 { get; set; }
        public bool SomeColumn18 { get; set; }
        public bool SomeColumn19 { get; set; }
        public bool SomeColumn20 { get; set; }
        public DateTime? SomeColumn21 { get; set; }
        public bool AllowMarketing { get; set; }
        public bool RemSuspended { get; set; }
        public bool EmailOptout { get; set; }
        public string CompanyName { get; set; }
        public string SharingPersonalData { get; set; }
    }
}
