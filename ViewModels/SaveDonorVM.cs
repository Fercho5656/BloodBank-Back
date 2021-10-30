using System;

namespace BloodBank_Backend.ViewModels {
    public class SaveDonorVM {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProfilePicURL { get; set; }

        //Relationships
        //BloodGroup
        public int BloodGroupId { get; set; }

        //ContactInfo
        public int ContactInfoId { get; set; }

        //BloodBank
        public int BloodBankId { get; set; }
    }
}