namespace BloodBank_Backend.ViewModels {
    public class SaveDonorVM {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Relationships
        //BloodGroup
        public int BloodGroupId { get; set; }

        //ContactInfo
        public int ContactInfoId { get; set; }

    }
}