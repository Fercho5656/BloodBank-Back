using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class BloodBank {
        public int Id { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public ContactInfo ContactInfo { get; set; }
    }
}