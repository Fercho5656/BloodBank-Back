using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class BloodBank : IEntityBase {
        public int Id { get; set; }
        [Required]
        public string BankName { get; set; }

        //Relationships

        //BloodGroups_BloodBanks
        public List<BloodGroup_BloodBank> BloodGroups_BloodBanks { get; set; }

        //Donor
        public List<Donor> Donors { get; set; }

        //Request
        public List<Request> Requests { get; set; }

        //ContactInfo
        public int? ContactInfoId { get; set; }
        [ForeignKey("ContactInfoId")]
        public ContactInfo ContactInfo { get; set; }
    }
}