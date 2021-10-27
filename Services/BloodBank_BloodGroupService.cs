using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;
using Microsoft.EntityFrameworkCore;

namespace bloodbank.Services {
    public class BloodBank_BloodGroupService : EntityBaseRepository<BloodGroup_BloodBank>, IBloodBank_BloodGroupService {

        private readonly BloodBankContext _context;
        public BloodBank_BloodGroupService(BloodBankContext context) : base(context) {
            _context = context;
        }

        public async Task<bool> BloodBankExists(int id) {
            return await Get(id) != null;
        }

        public async Task<bool> BloodGroupExists(int id) {
            return await Get(id) != null;
        }

        public async Task<IEnumerable> GetBloodBankById(int id) {
            if (!await _context.BloodBanks.AnyAsync(e => e.Id == id)) {
                return null;
            }
            return await _context.BloodGroups_BloodBanks
            .Where(x => x.BloodBankId == id)
            .Include(x => x.BloodGroup)
            .Include(x => x.BloodBank)
            .ToListAsync();
        }
    }
}