using System.Threading.Tasks;
using bloodbank.Models;
using BloodBank_Backend.Base;
using BloodBank_Backend.ViewModels;

namespace BloodBank_Backend.Services {
    public interface IHospitalService : IEntityBaseRepository<Hospital> {
        Task<Hospital> GetHospital(int id);
    }
}