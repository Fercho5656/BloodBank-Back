using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;

namespace BloodBank_Backend.Services {
    public class BloodTestService : EntityBaseRepository<BloodTest>, IBloodTestService {
        public BloodTestService(BloodBankContext context) : base(context) { }
    }

}