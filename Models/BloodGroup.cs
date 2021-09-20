using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class BloodGroup {
        public int Id { get; set; }
        [Required]
        public string BloodType { get; set; }
        [Required]
        public char RH { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public BloodBank BloodBank { get; set; }
    }
}