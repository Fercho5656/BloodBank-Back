using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
namespace bloodbank.Models {
    public class Disease {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Priority { get; set; }

    }
}