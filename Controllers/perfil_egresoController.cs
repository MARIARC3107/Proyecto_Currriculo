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
    public class perfil_egresoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public perfil_egresoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/perfil_egreso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<perfil_egreso>>> Getperfil_egreso()
        {
            return await _context.perfil_egreso.ToListAsync();
        }

        // GET: api/perfil_egreso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<perfil_egreso>> Getperfil_egreso(string id)
        {
            var perfil_egreso = await _context.perfil_egreso.FindAsync(id);

            if (perfil_egreso == null)
            {
                return NotFound();
            }

            return perfil_egreso;
        }

        // PUT: api/perfil_egreso/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putperfil_egreso(string id, perfil_egreso perfil_egreso)
        {
            if (id != perfil_egreso.id)
            {
                return BadRequest();
            }

            _context.Entry(perfil_egreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!perfil_egresoExists(id))
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

        // POST: api/perfil_egreso
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<perfil_egreso>> Postperfil_egreso(perfil_egreso perfil_egreso)
        {
            _context.perfil_egreso.Add(perfil_egreso);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (perfil_egresoExists(perfil_egreso.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Getperfil_egreso", new { id = perfil_egreso.id }, perfil_egreso);
        }

        // DELETE: api/perfil_egreso/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteperfil_egreso(string id)
        {
            var perfil_egreso = await _context.perfil_egreso.FindAsync(id);
            if (perfil_egreso == null)
            {
                return NotFound();
            }

            _context.perfil_egreso.Remove(perfil_egreso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool perfil_egresoExists(string id)
        {
            return _context.perfil_egreso.Any(e => e.id == id);
        }
    }
}
