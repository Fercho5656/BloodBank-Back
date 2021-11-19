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
    public class ContactInfoController : ControllerBase {
        private readonly IContactInfoService _service;
        private readonly IMapper _mapper;

        public ContactInfoController(IContactInfoService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/ContactInfo
        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var contactInfo = await _service.GetAll();
            var contactInfoVM = _mapper.Map<IEnumerable<ContactInfo>, IEnumerable<ContactInfoVM>>(contactInfo);
            return Ok(contactInfoVM);
        }

        // GET: api/ContactInfo/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var contactInfo = await _service.Get(id);
            if (contactInfo == null) return NotFound();
            var contactInfoVM = _mapper.Map<ContactInfoVM>(contactInfo);
            return Ok(contactInfoVM);
        }

        // POST: api/ContactInfo
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SaveContactInfoVM saveContactInfoVM) {
            var contactInfo = _mapper.Map<SaveContactInfoVM, ContactInfo>(saveContactInfoVM);
            await _service.Add(contactInfo);
            var contactInfoVM = _mapper.Map<ContactInfo, ContactInfoVM>(contactInfo);
            return CreatedAtAction(nameof(Add), new { id = contactInfoVM.Id }, contactInfoVM);
        }

        // PUT: api/ContactInfo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, SaveContactInfoVM newContactInfoVM) {
            var newContactInfo = _mapper.Map<SaveContactInfoVM, ContactInfo>(newContactInfoVM);
            newContactInfo.Id = id;
            var result = await _service.Update(id, newContactInfo);
            if (result == null) return NotFound();
            return NoContent();
        }

        // DELETE: api/ContactInfo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var contactInfo = await _service.Get(id);
            if (contactInfo == null) return NotFound();
            await _service.Delete(id);
            return NoContent();
        }
    }
}