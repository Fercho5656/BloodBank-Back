using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Services;
using BloodBank_Backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bloodbank.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class BloodBanksController : ControllerBase {
        private readonly IBloodBankService _service;
        private readonly IMapper _mapper;
        public BloodBanksController(IBloodBankService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/BloodBanks
        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var bloodBanks = await _service.GetAll(b => b.ContactInfo);
            var bloodBanksVM = _mapper.Map<IEnumerable<BloodBank>, IEnumerable<BloodBankVM>>(bloodBanks);
            return Ok(bloodBanksVM);
        }

        // GET: api/BloodBanks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var bloodBank = await _service.GetBloodBank(id);
            if (bloodBank == null) return NotFound();
            var bloodBankVM = _mapper.Map<BloodBank, BloodBankVM>(bloodBank);
            return Ok(bloodBankVM);
        }

        // POST: api/BloodBanks
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SaveBloodBankVM saveBloodBankVM) {
            var bloodBank = _mapper.Map<SaveBloodBankVM, BloodBank>(saveBloodBankVM);
            await _service.AddBloodBank(bloodBank);
            var bloodBankVM = _mapper.Map<BloodBank, BloodBankVM>(bloodBank);
            return CreatedAtAction(nameof(Add), new { id = bloodBankVM.Id }, bloodBankVM);
        }

        // PUT: api/BloodBanks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, SaveBloodBankVM newSaveBloodBankVM) {
            var newBloodBank = _mapper.Map<SaveBloodBankVM, BloodBank>(newSaveBloodBankVM);
            newBloodBank.Id = id;
            var result = await _service.Update(id, newBloodBank);
            if (result == null) return NotFound();
            return NoContent();
        }

        // DELETE: api/BloodBanks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var bloodBank = await _service.Get(id);
            if (bloodBank == null) return NotFound();
            await _service.Delete(id);
            return NoContent();
        }
    }
}