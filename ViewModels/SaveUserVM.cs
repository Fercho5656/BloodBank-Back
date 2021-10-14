namespace bloodbank.ViewModels {
    public class SaveUserVM {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfilePic { get; set; }

        //Relationships
        public int BloodBankId { get; set; }
        public int ContactInfoId { get; set; }
        public int RoleId { get; set; }
    }
}