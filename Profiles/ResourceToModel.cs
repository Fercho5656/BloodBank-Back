using AutoMapper;
using bloodbank.Models;
using BloodBank_Backend.ViewModels;

namespace BloodBank_Backend.Profiles {
    public class ResourceToModel : Profile {
        public ResourceToModel() {
            CreateMap<SaveRoleVM, Role>();
            CreateMap<SaveBloodBankVM, BloodBank>();
            CreateMap<SaveContactInfoVM, ContactInfo>();
        }
    }
}