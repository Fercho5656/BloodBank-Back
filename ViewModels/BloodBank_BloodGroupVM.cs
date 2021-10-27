using bloodbank.Models;
using BloodBank_Backend.ViewModels;

namespace bloodbank.ViewModels {
    public class BloodBank_BloodGroupVM {
        public int Id { get; set; }
        public BloodBankVM BloodBank { get; set; }
        public BloodGroupVM BloodGroup { get; set; }
        public int Quantity { get; set; }

    }
}