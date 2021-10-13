using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class Disease : IEntityBase {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Priority { get; set; }

        //Relationships
        public List<Patient> Patients { get; set; }
    }
}