using System.Threading.Tasks;
using AutoMapper;
using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;
using BloodBank_Backend.Services;
using Microsoft.EntityFrameworkCore;

namespace bloodbank.Services {
    public class HospitalService : EntityBaseRepository<Hospital>, IHospitalService {

        private readonly BloodBankContext _context;
        private readonly IMapper _mapper;

        public HospitalService(BloodBankContext context, IMapper mapper) : base(context) {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Hospital> GetHospital(int id) {
            var hospital = await _context.Hospitals
            .Include(c => c.ContactInfo)
            .FirstOrDefaultAsync(h => h.Id == id);

            return hospital;
        }
    }
}