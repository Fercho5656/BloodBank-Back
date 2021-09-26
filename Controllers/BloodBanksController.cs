using System.Threading.Tasks;
using bloodbank.Context;
using bloodbank.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bloodbank.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class BloodBanksController : ControllerBase {
        private readonly BloodBankContext Context;
        public BloodBanksController(BloodBankContext context) {
            Context = context;
        }

        //GET
        [HttpGet]
        public async Task<ActionResult> GetAll() {
            var bloodBanks = await Context.BloodBanks.ToListAsync();
            if (bloodBanks == null) {
                return NoContent();
            }
            return Ok(bloodBanks);
        }

        //GET/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetBank(int? id) {
            if (id == null) {
                return BadRequest();
            }
            BloodBank bloodBank = await Context.BloodBanks.FindAsync(id);
            if (bloodBank is null) {
                return NotFound();
            }
            return Ok(bloodBank);
        }

        //POST
        [HttpPost]
        public async Task<ActionResult> Create(BloodBank bloodBank) {
            if (ModelState.IsValid) {
                await Context.BloodBanks.AddAsync(bloodBank);
                await Context.SaveChangesAsync();
            }
            return CreatedAtAction(nameof(Create), new { id = bloodBank.Id }, bloodBank);
        }

        //DELETE/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int? id) {
            if (id == null) {
                return BadRequest();
            }
            BloodBank bloodBank = await Context.BloodBanks.FindAsync(id);
            if (bloodBank is null) {
                return NotFound();
            }
            Context.BloodBanks.Remove(bloodBank);
            await Context.SaveChangesAsync();
            return NoContent();
        }

        //PUT/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int? id, BloodBank bloodBank) {
            if (id == null || id != bloodBank.Id) {
                return BadRequest();
            }
            Context.Entry(bloodBank).State = EntityState.Modified;
            await Context.SaveChangesAsync();

            return NoContent();
        }
    }
}