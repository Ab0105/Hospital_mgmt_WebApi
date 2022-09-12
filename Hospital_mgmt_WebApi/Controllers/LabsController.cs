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
    public class LabsController : ControllerBase
    {
        private readonly SprintOneTeam3Context _context;

        public LabsController(SprintOneTeam3Context context)
        {
            _context = context;
        }

        // GET: api/Labs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lab>>> GetLab()
        {
            return await _context.Lab.ToListAsync();
        }

        // GET: api/Labs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lab>> GetLab(string id)
        {
            var lab = await _context.Lab.FindAsync(id);

            if (lab == null)
            {
                return NotFound();
            }

            return lab;
        }

        // PUT: api/Labs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLab(string id, Lab lab)
        {
            if (id != lab.LabId)
            {
                return BadRequest();
            }

            _context.Entry(lab).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LabExists(id))
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

        // POST: api/Labs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Lab>> PostLab(Lab lab)
        {
            _context.Lab.Add(lab);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LabExists(lab.LabId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLab", new { id = lab.LabId }, lab);
        }

        // DELETE: api/Labs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Lab>> DeleteLab(string id)
        {
            var lab = await _context.Lab.FindAsync(id);
            if (lab == null)
            {
                return NotFound();
            }

            _context.Lab.Remove(lab);
            await _context.SaveChangesAsync();

            return lab;
        }

        private bool LabExists(string id)
        {
            return _context.Lab.Any(e => e.LabId == id);
        }
    }
}
