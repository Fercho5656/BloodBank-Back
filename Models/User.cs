using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class User : IEntityBase {
        public int Id { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ProfilePic { get; set; }

        //Relationships
        //BloodBank
        public int? BloodBankId { get; set; }
        [ForeignKey("BloodBankId")]
        public BloodBank BloodBank { get; set; }

        //ContactInfo
        public int? ContactInfoId { get; set; }
        [ForeignKey("ContactInfoId")]
        public ContactInfo ContactInfo { get; set; }

        //Role
        public int? RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}