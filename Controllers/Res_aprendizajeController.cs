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
    public class Res_aprendizajeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Res_aprendizajeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Res_aprendizaje
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Res_aprendizaje>>> GetRes_aprendizaje()
        {
            return await _context.Res_aprendizaje.ToListAsync();
        }

        // GET: api/Res_aprendizaje/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Res_aprendizaje>> GetRes_aprendizaje(string id)
        {
            var res_aprendizaje = await _context.Res_aprendizaje.FindAsync(id);

            if (res_aprendizaje == null)
            {
                return NotFound();
            }

            return res_aprendizaje;
        }

        // PUT: api/Res_aprendizaje/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRes_aprendizaje(string id, Res_aprendizaje res_aprendizaje)
        {
            if (id != res_aprendizaje.id_resultado)
            {
                return BadRequest();
            }

            _context.Entry(res_aprendizaje).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Res_aprendizajeExists(id))
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

        // POST: api/Res_aprendizaje
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Res_aprendizaje>> PostRes_aprendizaje(Res_aprendizaje res_aprendizaje)
        {
            _context.Res_aprendizaje.Add(res_aprendizaje);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Res_aprendizajeExists(res_aprendizaje.id_resultado))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRes_aprendizaje", new { id = res_aprendizaje.id_resultado }, res_aprendizaje);
        }

        // DELETE: api/Res_aprendizaje/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRes_aprendizaje(string id)
        {
            var res_aprendizaje = await _context.Res_aprendizaje.FindAsync(id);
            if (res_aprendizaje == null)
            {
                return NotFound();
            }

            _context.Res_aprendizaje.Remove(res_aprendizaje);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Res_aprendizajeExists(string id)
        {
            return _context.Res_aprendizaje.Any(e => e.id_resultado == id);
        }
    }
}
