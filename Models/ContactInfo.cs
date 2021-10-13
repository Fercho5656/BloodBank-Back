using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class ContactInfo : IEntityBase {
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }

        //Relationships
        public List<Hospital> Hospitals { get; set; }
        public List<User> Users { get; set; }
        public List<BloodBank> BloodBanks { get; set; }
        public List<Donor> Donors { get; set; }
        public List<Patient> Patients { get; set; }
    }
}