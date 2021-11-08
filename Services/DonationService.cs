using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;

namespace BloodBank_Backend.Services {
    public class DonationService : EntityBaseRepository<Donation>, IDonationService {
        public DonationService(BloodBankContext context) : base(context) { }
    }
}