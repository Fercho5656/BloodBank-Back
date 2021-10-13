using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class BloodGroup: IEntityBase {
        public int Id { get; set; }
        [Required]
        public string BloodType { get; set; }
        [Required]
        public char RH { get; set; }
        [Required]
        public int Quantity { get; set; }

        //Relationships
        public List<BloodGroup_BloodBank> BloodGroups_BloodBanks { get; set; }
        public List<Patient> Patients { get; set; }
        public List<Donor> Donors { get; set; }
        public List<Request> Requests { get; set; }
    }
}