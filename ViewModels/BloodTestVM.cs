using System;

namespace BloodBank_Backend.ViewModels {
    public class BloodTestVM {
        public int Id { get; set; }
        public string TestResults { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }

        //Relationships

        //Donor
        public DonorVM Donor { get; set; }

    }
}