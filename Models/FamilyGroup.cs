using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class FamilyGroup : IEntityBase {
        public int Id { get; set; }
        [Required]
        public string FamilyName { get; set; }

        //Relationships
        public List<Patient> Patients { get; set; }
        public List<Donor> Donors { get; set; }

    }
}