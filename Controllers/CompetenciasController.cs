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
    public class CompetenciasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CompetenciasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Competencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Competencias>>> GetCompetencias()
        {
            return await _context.Competencias.ToListAsync();
        }

        // GET: api/Competencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Competencias>> GetCompetencias(string id)
        {
            var competencias = await _context.Competencias.FindAsync(id);

            if (competencias == null)
            {
                return NotFound();
            }

            return competencias;
        }

        // PUT: api/Competencias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompetencias(string id, Competencias competencias)
        {
            if (id != competencias.id)
            {
                return BadRequest();
            }

            _context.Entry(competencias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompetenciasExists(id))
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

        // POST: api/Competencias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Competencias>> PostCompetencias(Competencias competencias)
        {
            _context.Competencias.Add(competencias);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CompetenciasExists(competencias.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCompetencias", new { id = competencias.id }, competencias);
        }

        // DELETE: api/Competencias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetencias(string id)
        {
            var competencias = await _context.Competencias.FindAsync(id);
            if (competencias == null)
            {
                return NotFound();
            }

            _context.Competencias.Remove(competencias);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompetenciasExists(string id)
        {
            return _context.Competencias.Any(e => e.id == id);
        }
    }
}
