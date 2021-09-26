using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bloodbank.Models {
    public class BloodGroup_BloodBank {
        public int Id { get; set; }
        public int BloodGroupId { get; set; }
        public BloodGroup BloodGroup { get; set; }

        public int BloodBankId { get; set; }
        public BloodBank BloodBank { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}