using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class Donor : IEntityBase {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }

        //Relationships
        //IncomingBlood
        public List<IncomingBlood> IncomingBloods { get; set; }

        //FamilyGroup
        public int? FamilyGroupId { get; set; }
        [ForeignKey("FamilyGroupId")]
        public FamilyGroup FamilyGroup { get; set; }

        //BloodGroup
        public int? BloodGroupId { get; set; }
        [ForeignKey("BloodGroupId")]
        public BloodGroup BloodGroup { get; set; }

        //ContactInfo
        public int? ContactInfoId { get; set; }
        [ForeignKey("ContactInfoId")]
        public ContactInfo ContactInfo { get; set; }


    }
}