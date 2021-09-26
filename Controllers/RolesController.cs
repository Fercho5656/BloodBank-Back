using System.Threading.Tasks;
using bloodbank.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bloodbank.Models;
using BloodBank_Backend.Services;
using BloodBank_Backend.ViewModels;

namespace bloodbank.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase {

        private readonly RolesService _rolesService;

        public RolesController(RolesService rolesService) {
            _rolesService = rolesService;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var roles = _rolesService.GetAll();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        public IActionResult GetRole(int id) {
            var role = _rolesService.GetRole(id);
            return Ok(role);
        }

        [HttpPost]
        public IActionResult Create([FromBody] RoleVM role) {
            _rolesService.AddRole(role);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] RoleVM role) {
            var updatedRole = _rolesService.Update(id, role);
            return Ok(updatedRole);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            _rolesService.Delete(id);
            return Ok();
        }
    }
}