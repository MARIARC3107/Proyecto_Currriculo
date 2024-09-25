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
    public class AProfesionalsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AProfesionalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AProfesionals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AProfesional>>> GetAProfesional()
        {
            return await _context.AProfesional.ToListAsync();
        }

        // GET: api/AProfesionals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AProfesional>> GetAProfesional(string id)
        {
            var aProfesional = await _context.AProfesional.FindAsync(id);

            if (aProfesional == null)
            {
                return NotFound();
            }

            return aProfesional;
        }

        // PUT: api/AProfesionals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAProfesional(string id, AProfesional aProfesional)
        {
            if (id != aProfesional.id)
            {
                return BadRequest();
            }

            _context.Entry(aProfesional).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AProfesionalExists(id))
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

        // POST: api/AProfesionals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AProfesional>> PostAProfesional(AProfesional aProfesional)
        {
            _context.AProfesional.Add(aProfesional);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AProfesionalExists(aProfesional.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAProfesional", new { id = aProfesional.id }, aProfesional);
        }

        // DELETE: api/AProfesionals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAProfesional(string id)
        {
            var aProfesional = await _context.AProfesional.FindAsync(id);
            if (aProfesional == null)
            {
                return NotFound();
            }

            _context.AProfesional.Remove(aProfesional);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AProfesionalExists(string id)
        {
            return _context.AProfesional.Any(e => e.id == id);
        }
    }
}
