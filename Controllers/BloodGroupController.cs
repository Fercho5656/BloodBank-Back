using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using bloodbank.Models;
using bloodbank.Services;
using bloodbank.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bloodbank.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class BloodGroupController : ControllerBase {
        private readonly IBloodGroupService _service;
        private readonly IMapper _mapper;

        public BloodGroupController(IBloodGroupService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/BloodGroup
        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var result = await _service.GetAll();
            if (result == null) return NotFound();
            var resultVM = _mapper.Map<IEnumerable<BloodGroup>, IEnumerable<BloodGroupVM>>(result);
            return Ok(resultVM);
        }

        // GET: api/BloodGroup/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            var result = await _service.Get(id);
            var resultVM = _mapper.Map<BloodGroup, BloodGroupVM>(result);
            return Ok(resultVM);
        }

        // POST: api/BloodGroup
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SaveBloodGroupVM model) {
            var bloodGroup = _mapper.Map<SaveBloodGroupVM, BloodGroup>(model);
            await _service.Add(bloodGroup);
            var BloodGroupVM = _mapper.Map<BloodGroup, BloodGroupVM>(bloodGroup);
            return CreatedAtAction(nameof(Create), new { id = BloodGroupVM.Id }, BloodGroupVM);
        }

        // PUT: api/BloodGroup/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] BloodGroupVM model) {
            var bloodGroup = _mapper.Map<BloodGroupVM, BloodGroup>(model);
            bloodGroup.Id = id;
            var result = await _service.Update(id, bloodGroup);
            if (result == null) return NotFound();
            return NoContent();
        }

        // DELETE: api/BloodGroup/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var result = await _service.Get(id);
            if (result == null) return NotFound();
            await _service.Delete(id);
            return NoContent();
        }
    }
}