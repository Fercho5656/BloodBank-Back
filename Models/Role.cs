using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class Role {
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}