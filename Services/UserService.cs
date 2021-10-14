using System.Collections.Generic;
using System.Threading.Tasks;
using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;
using Microsoft.EntityFrameworkCore;

namespace bloodbank.Services {
    public class UserService : EntityBaseRepository<User>, IUserService {

        private readonly BloodBankContext _context;

        public UserService(BloodBankContext context) : base(context) {
            _context = context;
        }

        public Task AddUser(User user) {
            throw new System.NotImplementedException();
        }

        public async Task<User> GetUser(int id) {
            var user = await _context.Users
                .Include(b => b.BloodBank)
                    .ThenInclude(c => c.ContactInfo)
                .Include(c => c.ContactInfo)
                .Include(r => r.Role)
                .FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }
    }
}