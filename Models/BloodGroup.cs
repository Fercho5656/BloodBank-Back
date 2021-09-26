using System.Collections.Generic;
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
        public virtual List<BloodGroup_BloodBank> BloodGroups_BloodBanks { get; set; }
    }
}