using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class Donor {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public FamilyGroup FamilyGroup { get; set; }
        [Required]
        public BloodGroup BloodGroup { get; set; }
        [Required]
        public ContactInfo ContactInfo { get; set; }
    }
}