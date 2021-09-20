using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class Hospital {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ContactInfo ContactInfo { get; set; }
    }
}