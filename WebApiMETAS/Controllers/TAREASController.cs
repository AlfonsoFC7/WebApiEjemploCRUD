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
    public class TAREASController : ControllerBase
    {
        private readonly DtContext _context;

        public TAREASController(DtContext context)
        {
            _context = context;
        }

        // GET: api/TAREAS
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TAREAS>>> GetTAREAs()
        {
            return await _context.TAREAs.ToListAsync();
        }

        // GET: api/TAREAS/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TAREAS>> GetTAREAS(int id)
        {
            var tAREAS = await _context.TAREAs.FindAsync(id);

            if (tAREAS == null)
            {
                return NotFound();
            }

            return tAREAS;
        }

        // PUT: api/TAREAS/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTAREAS(int id, TAREAS tAREAS)
        {
            if (id != tAREAS.IdTarea)
            {
                return BadRequest();
            }

            _context.Entry(tAREAS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TAREASExists(id))
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

        // POST: api/TAREAS
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TAREAS>> PostTAREAS(TAREAS tAREAS)
        {
            _context.TAREAs.Add(tAREAS);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTAREAS", new { id = tAREAS.IdTarea }, tAREAS);
        }

        // DELETE: api/TAREAS/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTAREAS(int id)
        {
            var tAREAS = await _context.TAREAs.FindAsync(id);
            if (tAREAS == null)
            {
                return NotFound();
            }

            _context.TAREAs.Remove(tAREAS);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TAREASExists(int id)
        {
            return _context.TAREAs.Any(e => e.IdTarea == id);
        }
    }
}
