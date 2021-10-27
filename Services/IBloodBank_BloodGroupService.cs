using System.Threading.Tasks;
using bloodbank.Models;
using BloodBank_Backend.Base;

namespace bloodbank.Services {
    public interface IBloodBank_BloodGroupService : IEntityBaseRepository<BloodGroup_BloodBank> {
        Task<bool> BloodGroupExists(int id);
        Task<bool> BloodBankExists(int id);
    }
}