using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using bloodbank.Models;
using bloodbank.Services;
using bloodbank.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bloodbank.Controllers {
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController : ControllerBase {
        private readonly IUserService _service;
        private readonly IMapper _mapper;

        public UsersController(IUserService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var users = await _service.GetAll(b => b.BloodBank, c => c.ContactInfo, r => r.Role);
            var usersVM = _mapper.Map<IEnumerable<User>, IEnumerable<UserVM>>(users);
            return Ok(usersVM);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var user = await _service.GetUser(id);
            if (user == null) return NotFound();
            var userVM = _mapper.Map<User, UserVM>(user);
            return Ok(userVM);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SaveUserVM saveUserVM) {
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(saveUserVM.Password);
            var user = _mapper.Map<SaveUserVM, User>(saveUserVM);
            user.Password = hashedPassword;
            await _service.Add(user);
            var userVM = _mapper.Map<User, UserVM>(user);
            return CreatedAtAction(nameof(Add), new { id = userVM.Id }, userVM);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, SaveUserVM saveUserVM) {
            var newHashedPassword = BCrypt.Net.BCrypt.HashPassword(saveUserVM.Password);
            var newUser = _mapper.Map<SaveUserVM, User>(saveUserVM);
            newUser.Password = newHashedPassword;
            newUser.Id = id;
            var result = await _service.Update(id, newUser);
            if (result == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var user = await _service.Get(id);
            if (user == null) return NotFound();
            await _service.Delete(id);
            return NoContent();
        }
    }
}