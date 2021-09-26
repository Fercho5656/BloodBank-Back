using System.Collections.Generic;
using System.Linq;
using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.ViewModels;

namespace BloodBank_Backend.Services {
    public class RolesService {
        private BloodBankContext _context;
        public RolesService(BloodBankContext context) {
            _context = context;
        }

        public async void AddRole(RoleVM role) {
            var _role = new Role() {
                RoleName = role.RoleName
            };
            await _context.Roles.AddAsync(_role);
            await _context.SaveChangesAsync();
        }

        public List<Role> GetAll() {
            return _context.Roles.ToList();
        }

        public Role GetRole(int id) {
            return _context.Roles.FirstOrDefault(role => role.Id == id);
        }

        public Role Update(int id, RoleVM role) {
            var _role = _context.Roles.FirstOrDefault(role => role.Id == id);
            if (_role != null) {
                _role.RoleName = role.RoleName;
                _context.SaveChanges();
            }
            return _role;
        }

        public void Delete(int id) {
            var _role = _context.Roles.FirstOrDefault(role => role.Id == id);
            if (_role != null) {
                _context.Roles.Remove(_role);
                _context.SaveChanges();
            }
        }
    }
}