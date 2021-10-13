using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using bloodbank.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bloodbank.Models;
using BloodBank_Backend.Services;
using BloodBank_Backend.ViewModels;
using AutoMapper;

namespace bloodbank.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase {

        private readonly IRolesServices _service;
        private readonly IMapper _mapper;

        public RolesController(IRolesServices rolesService, IMapper mapper) {
            _service = rolesService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var roles = await _service.GetAll();
            var rolesVM = _mapper.Map<IEnumerable<Role>, IEnumerable<RoleVM>>(roles);
            return Ok(rolesVM);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRole(int id) {
            var role = await _service.Get(id);
            if (role == null) return NotFound();
            var roleVM = _mapper.Map<RoleVM>(role);
            return Ok(roleVM);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SaveRoleVM saveRoleVM) {
            var role = _mapper.Map<SaveRoleVM, Role>(saveRoleVM);
            await _service.Add(role);
            var roleVM = _mapper.Map<Role, RoleVM>(role);
            return CreatedAtAction(nameof(Add), new { id = roleVM.Id }, roleVM);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SaveRoleVM newRoleVM) {
            var newRole = _mapper.Map<SaveRoleVM, Role>(newRoleVM);
            newRole.Id = id;
            var result = await _service.Update(id, newRole);
            if (result == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var role = await _service.Get(id);
            if (role == null) return NotFound();
            await _service.Delete(id);
            return NoContent();
        }
    }
}