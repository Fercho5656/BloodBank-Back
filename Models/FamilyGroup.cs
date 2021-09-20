using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class FamilyGroup {
        public int Id { get; set; }
        [Required]
        public string FamilyName { get; set; }

    }
}