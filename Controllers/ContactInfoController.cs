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
    public class ContactInfoController : ControllerBase {
        private readonly ContactInfoService _contactInfoService;

        public ContactInfoController(ContactInfoService contactInfoService) {
            _contactInfoService = contactInfoService;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var contactInfo = _contactInfoService.GetAll();
            return Ok(contactInfo);
        }

        [HttpGet("{id}")]
        public IActionResult GetContactInfo(int id) {
            var contactInfo = _contactInfoService.GetContactInfo(id);
            return Ok(contactInfo);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ContactInfoVM contactInfo) {
            _contactInfoService.AddContactInfo(contactInfo);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ContactInfoVM contactInfo) {
            _contactInfoService.Update(id, contactInfo);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            _contactInfoService.Delete(id);
            return Ok();
        }
    }
}