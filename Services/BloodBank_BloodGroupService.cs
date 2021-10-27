using System.Threading.Tasks;
using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;

namespace bloodbank.Services {
    public class BloodBank_BloodGroupService : EntityBaseRepository<BloodGroup_BloodBank>, IBloodBank_BloodGroupService {
        public BloodBank_BloodGroupService(BloodBankContext context) : base(context) { }

        public async Task<bool> BloodBankExists(int id) {
            return await Get(id) != null;
        }

        public async Task<bool> BloodGroupExists(int id) {
            return await Get(id) != null;
        }
    }
}