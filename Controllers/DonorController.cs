using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using bloodbank.Models;
using bloodbank.Services;
using BloodBank_Backend.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bloodbank.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : ControllerBase {
        private readonly IDonorService _service;
        private readonly IMapper _mapper;
        public DonorController(IDonorService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Donor
        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var result = await _service.GetAll(b => b.BloodGroup, c => c.ContactInfo, b => b.BloodBank);
            var DonorsVM = _mapper.Map<IEnumerable<DonorVM>>(result);
            return Ok(DonorsVM);
        }

        // GET: api/Donor/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            var result = await _service.Get(id);
            if (result == null) return NotFound();
            var DonorVM = _mapper.Map<DonorVM>(result);
            return Ok(DonorVM);
        }

        // POST: api/Donor
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SaveDonorVM saveNewDonor) {
            var newDonor = _mapper.Map<Donor>(saveNewDonor);
            await _service.Add(newDonor);
            var newDonorVM = _mapper.Map<DonorVM>(newDonor);
            return CreatedAtAction(nameof(Create), new { id = newDonorVM.Id }, newDonorVM);
        }

        // PUT: api/Donor/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SaveDonorVM saveDonor) {
            var newDonor = _mapper.Map<SaveDonorVM, Donor>(saveDonor);
            newDonor.Id = id;
            var result = await _service.Update(id, newDonor);
            if (result == null) return NotFound();
            return NoContent();
        }

        // DELETE: api/Donor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var donor = await _service.Get(id);
            if (donor == null) return NotFound();
            await _service.Delete(id);
            return NoContent();
        }
    }
}