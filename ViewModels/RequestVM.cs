using System;
using bloodbank.ViewModels;

namespace BloodBank_Backend.ViewModels {
    public class RequestVM {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public bool Active { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        
        //Relationships
        //Hospital
        public HospitalVM Hospital { get; set; }

        //BloodGroup
        public BloodGroupVM BloodGroup { get; set; }

        //BloodBank
        public BloodBankVM BloodBank { get; set; }

    }
}