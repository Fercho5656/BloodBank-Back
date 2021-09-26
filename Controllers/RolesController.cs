using System.Threading.Tasks;
using bloodbank.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bloodbank.Models;

namespace bloodbank.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase {

        private readonly BloodBankContext Context;

        public RolesController(BloodBankContext context) {
            Context = context;
        }
        //GET
        [HttpGet]
        public async Task<ActionResult> GetAll() {
            var roles = await Context.Roles.ToListAsync();
            if (roles == null) {
                return NotFound();
            }
            return Ok(roles);
        }
        //GET/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetRole(int? id) {
            if (id == null) {
                return BadRequest();
            }
            Role role = await Context.Roles.FindAsync(id);
            if (role == null) {
                return NotFound();
            }
            return Ok(role);
        }
        //POST
        [HttpPost]
        public async Task<ActionResult> Create(Role role) {
            if (ModelState.IsValid) {
                await Context.Roles.AddAsync(role);
                await Context.SaveChangesAsync();
            }
            return CreatedAtAction(nameof(Create), new { id = role.Id }, role);
        }

        //DELETE/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int? id) {
            if (id == null) {
                return BadRequest();
            }
            Role role = await Context.Roles.FindAsync(id);
            if (role is null) {
                return NotFound();
            }
            Context.Roles.Remove(role);
            await Context.SaveChangesAsync();
            return NoContent();
        }
        //PUT/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int? id, Role role) {
            if (id == null || id != role.Id) {
                return BadRequest();
            }
            Context.Entry(role).State = EntityState.Modified;
            await Context.SaveChangesAsync();

            return NoContent();
        }
    }
}