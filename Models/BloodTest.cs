using System;
using System.ComponentModel.DataAnnotations;

namespace bloodbank.Models {
    public class BloodTest {
        public int Id { get; set; }
        [Required]
        public string TestResults { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public Donor Donor { get; set; }
    }
}