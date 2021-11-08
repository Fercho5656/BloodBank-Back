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
    public class DonationController : ControllerBase {
        private readonly IDonationService _service;
        private readonly IMapper _mapper;
        public DonationController(IDonationService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var donations = await _service.GetAll(d => d.Donor, b => b.BloodTest);
            var donationsVM = _mapper.Map<IEnumerable<Donation>, IEnumerable<DonationVM>>(donations);
            return Ok(donationsVM);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var donation = await _service.Get(id, d => d.Donor, b => b.BloodTest);
            if (donation == null) return NotFound();
            var donationVM = _mapper.Map<Donation, DonationVM>(donation);
            return Ok(donationVM);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SaveDonationVM saveDonationVM) {
            var donation = _mapper.Map<SaveDonationVM, Donation>(saveDonationVM);
            await _service.Add(donation);
            var donationVM = _mapper.Map<Donation, DonationVM>(donation);
            return CreatedAtAction(nameof(Add), new { id = donationVM.Id }, donationVM);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SaveDonationVM saveDonationVM) {
            var newDonation = _mapper.Map<SaveDonationVM, Donation>(saveDonationVM);
            newDonation.Id = id;
            var result = await _service.Update(id, newDonation);
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