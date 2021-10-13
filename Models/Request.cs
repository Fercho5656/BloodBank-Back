using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class Request : IEntityBase {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public char Status { get; set; }

        //Relationships
        //Patient
        public int? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        //BloodGroup
        public int? BloodGroupId { get; set; }
        [ForeignKey("BloodGroupId")]
        public BloodGroup BloodGroup { get; set; }
    }
}