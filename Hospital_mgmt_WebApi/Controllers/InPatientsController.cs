using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital_mgmt_WebApi.Model;

namespace Hospital_mgmt_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InPatientsController : ControllerBase
    {
        private readonly SprintOneTeam3Context _context;

        public InPatientsController(SprintOneTeam3Context context)
        {
            _context = context;
        }

        // GET: api/InPatients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InPatient>>> GetInPatient()
        {
            return await _context.InPatient.ToListAsync();
        }

        // GET: api/InPatients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InPatient>> GetInPatient(string id)
        {
            var inPatient = await _context.InPatient.FindAsync(id);

            if (inPatient == null)
            {
                return NotFound();
            }

            return inPatient;
        }

        // PUT: api/InPatients/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInPatient(string id, InPatient inPatient)
        {
            if (id != inPatient.Pid)
            {
                return BadRequest();
            }

            _context.Entry(inPatient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InPatientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/InPatients
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InPatient>> PostInPatient(InPatient inPatient)
        {
            _context.InPatient.Add(inPatient);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InPatientExists(inPatient.Pid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInPatient", new { id = inPatient.Pid }, inPatient);
        }

        // DELETE: api/InPatients/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InPatient>> DeleteInPatient(string id)
        {
            var inPatient = await _context.InPatient.FindAsync(id);
            if (inPatient == null)
            {
                return NotFound();
            }

            _context.InPatient.Remove(inPatient);
            await _context.SaveChangesAsync();

            return inPatient;
        }

        private bool InPatientExists(string id)
        {
            return _context.InPatient.Any(e => e.Pid == id);
        }
    }
}
