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
    public class OutpatientsController : ControllerBase
    {
        private readonly SprintOneTeam3Context _context;

        public OutpatientsController(SprintOneTeam3Context context)
        {
            _context = context;
        }

        // GET: api/Outpatients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Outpatient>>> GetOutpatient()
        {
            return await _context.Outpatient.ToListAsync();
        }

        // GET: api/Outpatients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Outpatient>> GetOutpatient(string id)
        {
            var outpatient = await _context.Outpatient.FindAsync(id);

            if (outpatient == null)
            {
                return NotFound();
            }

            return outpatient;
        }

        // PUT: api/Outpatients/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOutpatient(string id, Outpatient outpatient)
        {
            if (id != outpatient.Pid)
            {
                return BadRequest();
            }

            _context.Entry(outpatient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OutpatientExists(id))
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

        // POST: api/Outpatients
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Outpatient>> PostOutpatient(Outpatient outpatient)
        {
            _context.Outpatient.Add(outpatient);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OutpatientExists(outpatient.Pid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOutpatient", new { id = outpatient.Pid }, outpatient);
        }

        // DELETE: api/Outpatients/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Outpatient>> DeleteOutpatient(string id)
        {
            var outpatient = await _context.Outpatient.FindAsync(id);
            if (outpatient == null)
            {
                return NotFound();
            }

            _context.Outpatient.Remove(outpatient);
            await _context.SaveChangesAsync();

            return outpatient;
        }

        private bool OutpatientExists(string id)
        {
            return _context.Outpatient.Any(e => e.Pid == id);
        }
    }
}
