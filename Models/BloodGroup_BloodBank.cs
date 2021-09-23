using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bloodbank.Models {
    public class BloodGroup_BloodBank {
        [Key, Column(Order = 0)]
        public int BloodGroupId { get; set; }
        [Key, Column(Order = 1)]
        public int BloodBankId { get; set; }
        [ForeignKey("BloodGroupId")]
        public BloodGroup BloodGroup { get; set; }
        [ForeignKey("BloodBankId")]
        public BloodBank BloodBank { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}