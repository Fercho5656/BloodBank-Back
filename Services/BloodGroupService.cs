using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;

namespace bloodbank.Services {
    public class BloodGroupService : EntityBaseRepository<BloodGroup>, IBloodGroupService {

        public BloodGroupService(BloodBankContext context) : base(context) { }
    }
}