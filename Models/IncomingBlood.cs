using System;
using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class IncomingBlood {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public Donor Donor { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public BloodTest BloodTest { get; set; }
    }
}