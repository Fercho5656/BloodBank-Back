using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class Donation : IEntityBase {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime Date { get; set; }

        //Relationships
        //Donor
        public int? DonorId { get; set; }
        [ForeignKey("DonorId")]
        public Donor Donor { get; set; }

        //BloodTest
        public int? BloodTestId { get; set; }
        [ForeignKey("BloodTestId")]
        public BloodTest BloodTest { get; set; }
    }
}