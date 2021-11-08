using System;

namespace BloodBank_Backend.ViewModels {
    public class DonationVM {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        //Relationships
        //Donor
        public DonorVM Donor { get; set; }

        //BloodTest
        public BloodTestVM BloodTest { get; set; }

    }
}