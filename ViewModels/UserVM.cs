using BloodBank_Backend.ViewModels;

namespace bloodbank.ViewModels {
    public class UserVM {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string ProfilePic { get; set; }

        //Relationships
        public BloodBankVM BloodBank { get; set; }
        public ContactInfoVM ContactInfo { get; set; }
        public RoleVM Role { get; set; }
    }
}