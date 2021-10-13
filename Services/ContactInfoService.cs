using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;
using BloodBank_Backend.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BloodBank_Backend.Services {
    public class ContactInfoService : EntityBaseRepository<ContactInfo>, IContactInfoService {
        public ContactInfoService(BloodBankContext context) : base(context) { }
    }
}