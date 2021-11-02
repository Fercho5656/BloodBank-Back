namespace BloodBank_Backend.ViewModels {
    public class SaveRequestVM {
        public int Quantity { get; set; }
        public bool Active { get; set; }
        public char Status { get; set; }

        //Relationships
        //Hospital
        public int HospitalId { get; set; }

        //BloodGroup
        public int BloodGroupId { get; set; }

    }
}