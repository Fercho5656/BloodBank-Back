using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class Role : IEntityBase {
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }

        //Relationships
        public List<User> Users { get; set; }
    }
}