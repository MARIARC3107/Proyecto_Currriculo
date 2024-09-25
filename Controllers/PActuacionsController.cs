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
    public class PActuacionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PActuacionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PActuacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PActuacion>>> GetPActuacion()
        {
            return await _context.PActuacion.ToListAsync();
        }

        // GET: api/PActuacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PActuacion>> GetPActuacion(string id)
        {
            var pActuacion = await _context.PActuacion.FindAsync(id);

            if (pActuacion == null)
            {
                return NotFound();
            }

            return pActuacion;
        }

        // PUT: api/PActuacions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPActuacion(string id, PActuacion pActuacion)
        {
            if (id != pActuacion.id)
            {
                return BadRequest();
            }

            _context.Entry(pActuacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PActuacionExists(id))
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

        // POST: api/PActuacions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PActuacion>> PostPActuacion(PActuacion pActuacion)
        {
            _context.PActuacion.Add(pActuacion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PActuacionExists(pActuacion.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPActuacion", new { id = pActuacion.id }, pActuacion);
        }

        // DELETE: api/PActuacions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePActuacion(string id)
        {
            var pActuacion = await _context.PActuacion.FindAsync(id);
            if (pActuacion == null)
            {
                return NotFound();
            }

            _context.PActuacion.Remove(pActuacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PActuacionExists(string id)
        {
            return _context.PActuacion.Any(e => e.id == id);
        }
    }
}
