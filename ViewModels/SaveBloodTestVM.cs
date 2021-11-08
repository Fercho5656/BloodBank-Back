using System;

namespace BloodBank_Backend.ViewModels {
    public class SaveBloodTestVM {
        public string TestResults { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }

        //Relationships

        //Donor
        public int DonorId { get; set; }

    }
}