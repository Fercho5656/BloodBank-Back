using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class BloodTest : IEntityBase {
        public int Id { get; set; }
        [Required]
        public string TestResults { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Details { get; set; }

        //Relationships

        //IncomingBlood
        public Donation Donation { get; set; }

        //Donor
        public int? DonorId { get; set; }
        [ForeignKey("DonorId")]
        public Donor Donor { get; set; }

    }
}