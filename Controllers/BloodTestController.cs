using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using bloodbank.Models;
using BloodBank_Backend.Services;
using BloodBank_Backend.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank_Backend.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class BloodTestController : ControllerBase {
        private readonly IBloodTestService _service;
        private readonly IMapper _mapper;

        public BloodTestController(IBloodTestService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var tests = await _service.GetAll(d => d.Donor);
            var testsVM = _mapper.Map<IEnumerable<BloodTest>, IEnumerable<BloodTestVM>>(tests);
            return Ok(testsVM);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            var test = await _service.Get(id, d => d.Donor);
            var testVM = _mapper.Map<BloodTest, BloodTestVM>(test);
            return Ok(testVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SaveBloodTestVM saveTestVM) {
            var test = _mapper.Map<SaveBloodTestVM, BloodTest>(saveTestVM);
            await _service.Add(test);
            var testVM = _mapper.Map<BloodTest, BloodTestVM>(test);
            return CreatedAtAction(nameof(Create), new { id = testVM.Id }, testVM);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SaveBloodTestVM saveTestVM) {
            var newTest = _mapper.Map<SaveBloodTestVM, BloodTest>(saveTestVM);
            newTest.Id = id;
            var result = await _service.Update(id, newTest);
            if (result == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var result = await _service.Get(id);
            if (result == null) return NotFound();
            await _service.Delete(id);
            return NoContent();
        }
    }
}