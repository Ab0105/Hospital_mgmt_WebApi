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
    public class BillDatasController : ControllerBase
    {
        private readonly SprintOneTeam3Context _context;

        public BillDatasController(SprintOneTeam3Context context)
        {
            _context = context;
        }

        // GET: api/BillDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BillData>>> GetBillData()
        {
            return await _context.BillData.ToListAsync();
        }

        // GET: api/BillDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BillData>> GetBillData(int id)
        {
            var billData = await _context.BillData.FindAsync(id);

            if (billData == null)
            {
                return NotFound();
            }

            return billData;
        }

        // PUT: api/BillDatas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBillData(int id, BillData billData)
        {
            if (id != billData.BillNo)
            {
                return BadRequest();
            }

            _context.Entry(billData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillDataExists(id))
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

        // POST: api/BillDatas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BillData>> PostBillData(BillData billData)
        {
            _context.BillData.Add(billData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBillData", new { id = billData.BillNo }, billData);
        }

        // DELETE: api/BillDatas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BillData>> DeleteBillData(int id)
        {
            var billData = await _context.BillData.FindAsync(id);
            if (billData == null)
            {
                return NotFound();
            }

            _context.BillData.Remove(billData);
            await _context.SaveChangesAsync();

            return billData;
        }

        private bool BillDataExists(int id)
        {
            return _context.BillData.Any(e => e.BillNo == id);
        }
    }
}
