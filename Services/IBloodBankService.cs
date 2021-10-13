using System.Threading.Tasks;
using bloodbank.Models;
using BloodBank_Backend.Base;
using BloodBank_Backend.ViewModels;

namespace BloodBank_Backend.Services {
    public interface IBloodBankService : IEntityBaseRepository<BloodBank> {
        Task<BloodBank> GetBloodBank(int id);
        Task AddBloodBank(BloodBank bloodBank);
    }
}