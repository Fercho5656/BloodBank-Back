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
    public class RequestController : ControllerBase {
        private readonly IRequestService _service;
        private readonly IMapper _mapper;

        public RequestController(IRequestService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var result = await _service.GetAll(h => h.Hospital, b => b.BloodGroup);
            var resultVM = _mapper.Map<IEnumerable<RequestVM>>(result);
            return Ok(resultVM);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            var result = await _service.Get(id, h => h.Hospital, b => b.BloodGroup);
            var resultVM = _mapper.Map<RequestVM>(result);
            return Ok(resultVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SaveRequestVM saveRequestVM) {
            var request = _mapper.Map<Request>(saveRequestVM);
            await _service.Add(request);
            var result = await _service.Get(request.Id, h => h.Hospital, b => b.BloodGroup);
            var resultVM = _mapper.Map<RequestVM>(result);
            return CreatedAtAction(nameof(Create), new { id = resultVM.Id, hospital = resultVM.Hospital, bloodGroup = resultVM.BloodGroup }, resultVM);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SaveRequestVM saveRequestVM) {
            var request = _mapper.Map<Request>(saveRequestVM);
            request.Id = id;
            var result = await _service.Update(id, request);
            if (result == null) return NotFound();
            var newResult = await _service.Get(id, h => h.Hospital, b => b.BloodGroup);
            var newResultVM = _mapper.Map<RequestVM>(newResult);
            return Ok(newResultVM);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var request = await _service.Get(id);
            if (request == null) return NotFound();
            await _service.Delete(id);
            return NoContent();
        }
    }
}