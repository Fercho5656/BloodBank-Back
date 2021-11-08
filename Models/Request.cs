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
        public string Status { get; set; }
        public DateTime Date { get; set; }

        //Relationships
        //Hospital
        public int? HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public Hospital Hospital { get; set; }

        //BloodGroup
        public int? BloodGroupId { get; set; }
        [ForeignKey("BloodGroupId")]
        public BloodGroup BloodGroup { get; set; }
    }
}