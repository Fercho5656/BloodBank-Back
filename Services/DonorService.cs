using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;

namespace bloodbank.Services {
    public class DonorService : EntityBaseRepository<Donor>, IDonorService {
        public DonorService(BloodBankContext context) : base(context) { }
    }
}