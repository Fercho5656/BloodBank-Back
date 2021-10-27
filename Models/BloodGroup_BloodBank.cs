using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class BloodGroup_BloodBank : IEntityBase {
        public int Id { get; set; }
        public int BloodGroupId { get; set; }
        public BloodGroup BloodGroup { get; set; }

        public int BloodBankId { get; set; }
        public BloodBank BloodBank { get; set; }
        public int Quantity { get; set; }
    }
}