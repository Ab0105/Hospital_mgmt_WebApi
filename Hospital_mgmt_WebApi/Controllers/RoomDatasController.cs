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
    public class RoomDatasController : ControllerBase
    {
        private readonly SprintOneTeam3Context _context;

        public RoomDatasController(SprintOneTeam3Context context)
        {
            _context = context;
        }

        // GET: api/RoomDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomData>>> GetRoomData()
        {
            return await _context.RoomData.ToListAsync();
        }

        // GET: api/RoomDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomData>> GetRoomData(string id)
        {
            var roomData = await _context.RoomData.FindAsync(id);

            if (roomData == null)
            {
                return NotFound();
            }

            return roomData;
        }

        // PUT: api/RoomDatas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomData(string id, RoomData roomData)
        {
            if (id != roomData.RoomNo)
            {
                return BadRequest();
            }

            _context.Entry(roomData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomDataExists(id))
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

        // POST: api/RoomDatas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RoomData>> PostRoomData(RoomData roomData)
        {
            _context.RoomData.Add(roomData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RoomDataExists(roomData.RoomNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRoomData", new { id = roomData.RoomNo }, roomData);
        }

        // DELETE: api/RoomDatas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RoomData>> DeleteRoomData(string id)
        {
            var roomData = await _context.RoomData.FindAsync(id);
            if (roomData == null)
            {
                return NotFound();
            }

            _context.RoomData.Remove(roomData);
            await _context.SaveChangesAsync();

            return roomData;
        }

        private bool RoomDataExists(string id)
        {
            return _context.RoomData.Any(e => e.RoomNo == id);
        }
    }
}
