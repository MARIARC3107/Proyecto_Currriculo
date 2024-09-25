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
    public class SabersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SabersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Sabers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Saber>>> GetSaber()
        {
            return await _context.Saber.ToListAsync();
        }

        // GET: api/Sabers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Saber>> GetSaber(string id)
        {
            var saber = await _context.Saber.FindAsync(id);

            if (saber == null)
            {
                return NotFound();
            }

            return saber;
        }

        // PUT: api/Sabers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaber(string id, Saber saber)
        {
            if (id != saber.id)
            {
                return BadRequest();
            }

            _context.Entry(saber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaberExists(id))
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

        // POST: api/Sabers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Saber>> PostSaber(Saber saber)
        {
            _context.Saber.Add(saber);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SaberExists(saber.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSaber", new { id = saber.id }, saber);
        }

        // DELETE: api/Sabers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaber(string id)
        {
            var saber = await _context.Saber.FindAsync(id);
            if (saber == null)
            {
                return NotFound();
            }

            _context.Saber.Remove(saber);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaberExists(string id)
        {
            return _context.Saber.Any(e => e.id == id);
        }
    }
}
