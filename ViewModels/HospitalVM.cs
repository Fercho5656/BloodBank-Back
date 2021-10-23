using BloodBank_Backend.ViewModels;

namespace bloodbank.ViewModels {
    public class HospitalVM {

        public int Id { get; set; }
        public string Name { get; set; }

        //Relationships
        //ContactInfo
        public ContactInfoVM ContactInfo { get; set; }
    }
}