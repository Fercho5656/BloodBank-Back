using AutoMapper;
using bloodbank.Models;
using bloodbank.ViewModels;
using BloodBank_Backend.ViewModels;

namespace BloodBank_Backend.Profiles {
    public class ModelToResource : Profile {
        public ModelToResource() {
            CreateMap<Role, RoleVM>();
            CreateMap<BloodBank, BloodBankVM>();
            CreateMap<BloodGroup, BloodGroupVM>();
            CreateMap<BloodGroup_BloodBank, BloodBank_BloodGroupVM>();
            CreateMap<ContactInfo, ContactInfoVM>();
            CreateMap<User, UserVM>();
            CreateMap<Hospital, HospitalVM>();
            CreateMap<Donor, DonorVM>();
            CreateMap<Request, RequestVM>();
            CreateMap<Donation, DonationVM>();
            CreateMap<BloodTest, BloodTestVM>();
        }
    }
}