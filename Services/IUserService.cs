using System.Collections.Generic;
using System.Threading.Tasks;
using bloodbank.Models;
using BloodBank_Backend.Base;

namespace bloodbank.Services {
    public interface IUserService : IEntityBaseRepository<User> {
        Task<User> GetUser(int id);
    }
}