using System;
using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class OutgoingBlood {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public Patient Patient { get; set; }
        [Required]
        public Hospital Hospital { get; set; }






    }
}