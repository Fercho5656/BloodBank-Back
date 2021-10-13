using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;
using BloodBank_Backend.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BloodBank_Backend.Services {
    public class RolesService : EntityBaseRepository<Role>, IRolesServices {
        public RolesService(BloodBankContext context) : base(context){}

    }
}