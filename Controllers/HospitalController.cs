using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using bloodbank.Models;
using bloodbank.ViewModels;
using BloodBank_Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace bloodbank.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class HospitalController : ControllerBase {
        private readonly IHospitalService _service;
        private readonly IMapper _mapper;

        public HospitalController(IHospitalService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var hospitals = await _service.GetAll(c => c.ContactInfo);
            var hospitalsVM = _mapper.Map<IEnumerable<Hospital>, IEnumerable<HospitalVM>>(hospitals);
            return Ok(hospitalsVM);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var hospital = await _service.GetHospital(id);
            if (hospital == null) return NotFound();
            var hospitalVM = _mapper.Map<Hospital, HospitalVM>(hospital);
            return Ok(hospitalVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveHospitalVM saveHospitalVM) {
            var hospital = _mapper.Map<SaveHospitalVM, Hospital>(saveHospitalVM);
            await _service.Add(hospital);
            var hospitalVM = _mapper.Map<Hospital, HospitalVM>(hospital);
            return CreatedAtAction(nameof(Create), new { id = hospitalVM.Id }, hospitalVM);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, SaveHospitalVM saveHospitalVM) {
            var newHospital = _mapper.Map<SaveHospitalVM, Hospital>(saveHospitalVM);
            newHospital.Id = id;
            var result = await _service.Update(id, newHospital);
            if (result == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var hospital = await _service.Get(id);
            if (hospital == null) return NotFound();
            await _service.Delete(id);
            return NoContent();
        }
    }
}