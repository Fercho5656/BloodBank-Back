using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class Patient : IEntityBase {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }

        //Relationships
        //Requests
        public List<Request> Requests { get; set; }
        //OutgoingBlood
        public List<OutgoingBlood> OutgoingBloods { get; set; }

        //Disease
        public int? DiseaseId { get; set; }
        [ForeignKey("DiseaseId")]
        public Disease Disease { get; set; }

        //BloodGroup
        public int? BloodGroupId { get; set; }
        [ForeignKey("BloodGroupId")]
        public BloodGroup BloodGroup { get; set; }

        //FamilyGroup
        public int? FamilyGroupId { get; set; }
        [ForeignKey("FamilyGroupId")]
        public FamilyGroup FamilyGroup { get; set; }

        //ContactInfo
        public int? ContactInfoId { get; set; }
        [ForeignKey("ContactInfoId")]
        public ContactInfo ContactInfo { get; set; }
    }
}