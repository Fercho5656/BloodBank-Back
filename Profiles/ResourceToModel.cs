using AutoMapper;
using bloodbank.Models;
using bloodbank.ViewModels;
using BloodBank_Backend.ViewModels;

namespace BloodBank_Backend.Profiles {
    public class ResourceToModel : Profile {
        public ResourceToModel() {
            CreateMap<SaveRoleVM, Role>();
            CreateMap<SaveBloodBankVM, BloodBank>();
            CreateMap<SaveContactInfoVM, ContactInfo>();
            CreateMap<SaveUserVM, User>();
            CreateMap<SaveHospitalVM, Hospital>();
        }
    }
}