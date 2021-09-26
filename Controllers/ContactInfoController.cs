using System.Threading.Tasks;
using bloodbank.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bloodbank.Models;

namespace bloodbank.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class ContactInfoController : ControllerBase {
        private readonly BloodBankContext Context;
        public ContactInfoController(BloodBankContext context) {
            Context = context;
        }

        //GET
        [HttpGet]
        public async Task<ActionResult> GetAll() {
            var contacts = await Context.ContactInfo.ToListAsync();
            if (contacts == null) {
                return NotFound();
            }
            return Ok(contacts);
        }

        //GET/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetContact(int? id) {
            if (id == null) {
                return BadRequest();
            }
            ContactInfo contact = await Context.ContactInfo.FindAsync(id);
            if (contact is null) {
                return NotFound();
            }
            return Ok(contact);
        }
        //POST
        [HttpPost]
        public async Task<ActionResult> Create(ContactInfo contact) {
            if (ModelState.IsValid) {
                await Context.ContactInfo.AddAsync(contact);
                await Context.SaveChangesAsync();
            }
            return CreatedAtAction(nameof(Create), new { id = contact.Id }, contact);
        }
        //DELETE/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int? id) {
            if (id == null) {
                return BadRequest();
            }
            ContactInfo contact = await Context.ContactInfo.FindAsync(id);
            if (contact is null) {
                return NotFound();
            }
            Context.ContactInfo.Remove(contact);
            await Context.SaveChangesAsync();
            return NoContent();
        }
        //PUT/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int? id, ContactInfo contact) {
            if (id == null || id != contact.Id) {
                return BadRequest();
            }
            Context.Entry(contact).State = EntityState.Modified;
            await Context.SaveChangesAsync();

            return NoContent();
        }
    }
}