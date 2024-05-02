using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impromed_client.Model
{
    internal class PATIENTS
    {
        public Guid PatientGuid { get; set; }
        public Guid ClientGuid { get; set; }
        public Guid SpeciesGuid { get; set; }
        public Guid BreedGuid { get; set; }
        public Guid ColorGuid { get; set; }
        public string PatientAccountId { get; set; }
        public string PatientName { get; set; }
        public Guid StableGuid { get; set; }
        public string Sex { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool Active { get; set; }
        public DateTime? LatestVisit { get; set; }
        public short PracticeVid { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid CreateUserGuid { get; set; }
        public Guid CreateWorkstationGuid { get; set; }
        public DateTime? DeceasedDate { get; set; }
        public DateTime? FirstVisit { get; set; }
        public string MaturityCode { get; set; }
        public string MedicalAlert { get; set; }
        public string ChronicAilment { get; set; }
        public string ContinuousMedication { get; set; }
        public string Comment { get; set; }
        public float Weight { get; set; }
        public Guid DoctorPreferenceGuid { get; set; }
        public Guid? ImageGuid { get; set; }
        public string TattooNum { get; set; }
        public string AvidChipNum { get; set; }
        public Guid ReferralSourceGuid { get; set; }
        public string RabiesTagNumber { get; set; }
        public string RabiesSerialNumber { get; set; }
        public string RabiesBrandName { get; set; }
        public Guid DeletedUniqifyingGuid { get; set; }
        public string SpecialInstructions { get; set; }
        public string SomeColumn1 { get; set; }
        public string SomeColumn2 { get; set; }
        public string SomeColumn3 { get; set; }
        public DateTime? SomeColumn4 { get; set; }
        public Guid HealthPlanGuid { get; set; }
        public string SomeColumn5 { get; set; }
        public string SomeColumn6 { get; set; }
        public string SomeColumn7 { get; set; }
        public string SomeColumn8 { get; set; }
        public string SomeColumn9 { get; set; }
        public bool SomeColumn10 { get; set; }
        public bool SomeColumn11 { get; set; }
        public bool SomeColumn12 { get; set; }
        public bool SomeColumn13 { get; set; }
        public bool SomeColumn14 { get; set; }
        public bool SomeColumn15 { get; set; }
        public bool SomeColumn16 { get; set; }
        public bool SomeColumn17 { get; set; }
        public string MicrochipManufacturer1 { get; set; }
        public string MicrochipManufacturer2 { get; set; }
        public bool MicrochipIsRegistered1 { get; set; }
        public bool MicrochipIsRegistered2 { get; set; }
        public string MicrochipNumber2 { get; set; }
    }
}
