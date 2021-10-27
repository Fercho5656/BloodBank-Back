using bloodbank.ViewModels;

namespace BloodBank_Backend.ViewModels {
    public class DonorVM {
        public int Id { get; set; }
        public string FullName { get; set; }

        //BloodGroup
        public BloodGroupVM BloodGroup { get; set; }

        //ContactInfo
        public ContactInfoVM ContactInfo { get; set; }

    }
}