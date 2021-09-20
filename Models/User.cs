using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class User {
        public int Id { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ProfilePic { get; set; }
        [Required]
        public BloodBank BloodBank { get; set; }
        [Required]
        public ContactInfo ContactInfo { get; set; }
        [Required]
        public Role Role { get; set; }
    }
}