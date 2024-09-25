using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_curriculo.Context;
using Proyecto_curriculo.Models;

namespace Proyecto_curriculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ATProfesionalesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ATProfesionalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ATProfesionales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ATProfesionales>>> GetATProfesionales()
        {
            return await _context.ATProfesionales.ToListAsync();
        }

        // GET: api/ATProfesionales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ATProfesionales>> GetATProfesionales(string id)
        {
            var aTProfesionales = await _context.ATProfesionales.FindAsync(id);

            if (aTProfesionales == null)
            {
                return NotFound();
            }

            return aTProfesionales;
        }

        // PUT: api/ATProfesionales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutATProfesionales(string id, ATProfesionales aTProfesionales)
        {
            if (id != aTProfesionales.id)
            {
                return BadRequest();
            }

            _context.Entry(aTProfesionales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ATProfesionalesExists(id))
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

        // POST: api/ATProfesionales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ATProfesionales>> PostATProfesionales(ATProfesionales aTProfesionales)
        {
            _context.ATProfesionales.Add(aTProfesionales);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ATProfesionalesExists(aTProfesionales.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetATProfesionales", new { id = aTProfesionales.id }, aTProfesionales);
        }

        // DELETE: api/ATProfesionales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteATProfesionales(string id)
        {
            var aTProfesionales = await _context.ATProfesionales.FindAsync(id);
            if (aTProfesionales == null)
            {
                return NotFound();
            }

            _context.ATProfesionales.Remove(aTProfesionales);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ATProfesionalesExists(string id)
        {
            return _context.ATProfesionales.Any(e => e.id == id);
        }
    }
}
