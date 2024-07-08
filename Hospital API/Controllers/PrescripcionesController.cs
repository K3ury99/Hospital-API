using Hospital_API.Context;
using Hospital_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescripcionesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public PrescripcionesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Prescripcions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prescripcion>>> GetPrescripciones()
        {
            return await _context.Prescripciones.ToListAsync();
        }

        // GET: api/Prescripcions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prescripcion>> GetPrescripcion(int id)
        {
            var prescripcion = await _context.Prescripciones.FindAsync(id);

            if (prescripcion == null)
            {
                return NotFound();
            }

            return prescripcion;
        }

        // PUT: api/Prescripcions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrescripcion(int id, Prescripcion prescripcion)
        {
            if (id != prescripcion.ID)
            {
                return BadRequest();
            }

            _context.Entry(prescripcion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrescripcionExists(id))
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

        // POST: api/Prescripcions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Prescripcion>> PostPrescripcion(Prescripcion prescripcion)
        {
            _context.Prescripciones.Add(prescripcion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrescripcion", new { id = prescripcion.ID }, prescripcion);
        }

        // DELETE: api/Prescripcions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrescripcion(int id)
        {
            var prescripcion = await _context.Prescripciones.FindAsync(id);
            if (prescripcion == null)
            {
                return NotFound();
            }

            _context.Prescripciones.Remove(prescripcion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrescripcionExists(int id)
        {
            return _context.Prescripciones.Any(e => e.ID == id);
        }
    }
}
