using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;
using BloodBank_Backend.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BloodBank_Backend.Services {
    public class BloodBankService : EntityBaseRepository<BloodBank>, IBloodBankService {

        private readonly BloodBankContext _context;
        private readonly IMapper _mapper;
        public BloodBankService(BloodBankContext context, IMapper mapper) : base(context) {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddBloodBank(BloodBank bloodBank) {
            await Add(bloodBank);
            await _context.SaveChangesAsync();
        }

        public async Task<BloodBank> GetBloodBank(int id) {
            var bloodBank = await _context.BloodBanks
                .Include(c => c.ContactInfo)
                .FirstOrDefaultAsync(b => b.Id == id);

            return bloodBank;
        }
    }
}