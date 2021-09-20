using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bloodbank.Models {
    public class Patient {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public Disease Disease { get; set; }
        [Required]
        public BloodGroup BloodGroup { get; set; }
        [Required]
        public FamilyGroup FamilyGroup { get; set; }
        [Required]
        public ContactInfo ContactInfo { get; set; }

    }
}