using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiMETAS.Data;
using WebApiMETAS.Entity;

namespace WebApiMETAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class METASController : ControllerBase
    {
        private readonly DtContext _context;

        public METASController(DtContext context)
        {
            _context = context;
        }

        // GET: api/METAS
        [HttpGet]
        public async Task<ActionResult<IEnumerable<METAS>>> GetMETAs()
        {
            return await _context.METAs.ToListAsync();
        }

        // GET: api/METAS/5
        [HttpGet("{id}")]
        public async Task<ActionResult<METAS>> GetMETAS(int id)
        {
            var mETAS = await _context.METAs.FindAsync(id);

            if (mETAS == null)
            {
                return NotFound();
            }

            return mETAS;
        }

        // PUT: api/METAS/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMETAS(int id, METAS mETAS)
        {
            if (id != mETAS.IdMeta)
            {
                return BadRequest();
            }

            _context.Entry(mETAS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!METASExists(id))
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

        // POST: api/METAS
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<METAS>> PostMETAS(METAS mETAS)
        {
            _context.METAs.Add(mETAS);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMETAS", new { id = mETAS.IdMeta }, mETAS);
        }

        // DELETE: api/METAS/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMETAS(int id)
        {
            var mETAS = await _context.METAs.FindAsync(id);
            if (mETAS == null)
            {
                return NotFound();
            }

            _context.METAs.Remove(mETAS);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool METASExists(int id)
        {
            return _context.METAs.Any(e => e.IdMeta == id);
        }
    }
}
