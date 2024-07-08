using Hospital_API.Context;
using Hospital_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalizacionesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public HospitalizacionesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Hospitalizacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hospitalizacion>>> GetHospitalizaciones()
        {
            return await _context.Hospitalizaciones.ToListAsync();
        }

        // GET: api/Hospitalizacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hospitalizacion>> GetHospitalizacion(int id)
        {
            var hospitalizacion = await _context.Hospitalizaciones.FindAsync(id);

            if (hospitalizacion == null)
            {
                return NotFound();
            }

            return hospitalizacion;
        }

        // PUT: api/Hospitalizacions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospitalizacion(int id, Hospitalizacion hospitalizacion)
        {
            if (id != hospitalizacion.ID)
            {
                return BadRequest();
            }

            _context.Entry(hospitalizacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HospitalizacionExists(id))
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

        // POST: api/Hospitalizacions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hospitalizacion>> PostHospitalizacion(Hospitalizacion hospitalizacion)
        {
            _context.Hospitalizaciones.Add(hospitalizacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHospitalizacion", new { id = hospitalizacion.ID }, hospitalizacion);
        }

        // DELETE: api/Hospitalizacions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospitalizacion(int id)
        {
            var hospitalizacion = await _context.Hospitalizaciones.FindAsync(id);
            if (hospitalizacion == null)
            {
                return NotFound();
            }

            _context.Hospitalizaciones.Remove(hospitalizacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HospitalizacionExists(int id)
        {
            return _context.Hospitalizaciones.Any(e => e.ID == id);
        }
    }
}
