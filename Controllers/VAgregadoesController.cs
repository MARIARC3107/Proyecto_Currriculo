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
    public class VAgregadoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VAgregadoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/VAgregadoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VAgregado>>> GetVAgregado()
        {
            return await _context.VAgregado.ToListAsync();
        }

        // GET: api/VAgregadoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VAgregado>> GetVAgregado(string id)
        {
            var vAgregado = await _context.VAgregado.FindAsync(id);

            if (vAgregado == null)
            {
                return NotFound();
            }

            return vAgregado;
        }

        // PUT: api/VAgregadoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVAgregado(string id, VAgregado vAgregado)
        {
            if (id != vAgregado.id)
            {
                return BadRequest();
            }

            _context.Entry(vAgregado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VAgregadoExists(id))
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

        // POST: api/VAgregadoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VAgregado>> PostVAgregado(VAgregado vAgregado)
        {
            _context.VAgregado.Add(vAgregado);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VAgregadoExists(vAgregado.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetVAgregado", new { id = vAgregado.id }, vAgregado);
        }

        // DELETE: api/VAgregadoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVAgregado(string id)
        {
            var vAgregado = await _context.VAgregado.FindAsync(id);
            if (vAgregado == null)
            {
                return NotFound();
            }

            _context.VAgregado.Remove(vAgregado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VAgregadoExists(string id)
        {
            return _context.VAgregado.Any(e => e.id == id);
        }
    }
}
