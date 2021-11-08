using System;

namespace BloodBank_Backend.ViewModels {
    public class SaveDonationVM {
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        //Relationships
        //Donor
        public int DonorId { get; set; }

        //BloodTest
        public int? BloodTestId { get; set; }

    }
}