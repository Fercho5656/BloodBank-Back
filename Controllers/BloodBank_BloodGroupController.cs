using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using bloodbank.Context;
using bloodbank.Models;
using bloodbank.Services;
using bloodbank.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bloodbank.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class BloodBank_BloodGroupController : ControllerBase {
        private readonly IBloodBank_BloodGroupService _service;
        private readonly IMapper _mapper;
        public BloodBank_BloodGroupController(IBloodBank_BloodGroupService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get() {
            var result = await _service.GetAll(b => b.BloodGroup, b => b.BloodBank);
            var resultVM = _mapper.Map<IEnumerable<BloodBank_BloodGroupVM>>(result);
            return Ok(resultVM);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var result = await _service.GetBloodBankById(id);
            if (result == null) return NotFound();
            var resultVM = _mapper.Map<IEnumerable<BloodBank_BloodGroupVM>>(result);
            return Ok(resultVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SaveBloodBank_BloodGroupVM model) {
            var bloodBank_BloodGroup = _mapper.Map<SaveBloodBank_BloodGroupVM, BloodGroup_BloodBank>(model);
            /* if (await _service.BloodBankExists(model.BloodBankId) || await _service.BloodGroupExists(model.BloodGroupId)){
                return BadRequest("BloodBank or BloodGroup does not exist");
            } */
            await _service.Add(bloodBank_BloodGroup);
            var bloodBank_BloodGroupVM = _mapper.Map<BloodGroup_BloodBank, BloodBank_BloodGroupVM>(bloodBank_BloodGroup);
            return CreatedAtAction(nameof(Create), new { id = bloodBank_BloodGroupVM.Id, bloodBank = bloodBank_BloodGroupVM.BloodBank }, bloodBank_BloodGroupVM);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SaveBloodBank_BloodGroupVM model) {
            var bloodBank_BloodGroup = _mapper.Map<BloodGroup_BloodBank>(model);
            bloodBank_BloodGroup.Id = id;
            var result = await _service.Update(id, bloodBank_BloodGroup);
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