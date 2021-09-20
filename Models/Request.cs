using System;
using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class Request {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public Boolean Active { get; set; }
        [Required]
        public Boolean Status { get; set; }
        [Required]
        public Patient Patient { get; set; }
        [Required]
        public BloodGroup BloodGroup { get; set; }
    }
}