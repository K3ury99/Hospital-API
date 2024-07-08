using Hospital_API.Context;
using Hospital_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboratoriosController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public LaboratoriosController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Laboratorios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Laboratorio>>> GetLaboratorios()
        {
            return await _context.Laboratorios.ToListAsync();
        }

        // GET: api/Laboratorios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Laboratorio>> GetLaboratorio(int id)
        {
            var laboratorio = await _context.Laboratorios.FindAsync(id);

            if (laboratorio == null)
            {
                return NotFound();
            }

            return laboratorio;
        }

        // PUT: api/Laboratorios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLaboratorio(int id, Laboratorio laboratorio)
        {
            if (id != laboratorio.ID)
            {
                return BadRequest();
            }

            _context.Entry(laboratorio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaboratorioExists(id))
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

        // POST: api/Laboratorios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Laboratorio>> PostLaboratorio(Laboratorio laboratorio)
        {
            _context.Laboratorios.Add(laboratorio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLaboratorio", new { id = laboratorio.ID }, laboratorio);
        }

        // DELETE: api/Laboratorios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLaboratorio(int id)
        {
            var laboratorio = await _context.Laboratorios.FindAsync(id);
            if (laboratorio == null)
            {
                return NotFound();
            }

            _context.Laboratorios.Remove(laboratorio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LaboratorioExists(int id)
        {
            return _context.Laboratorios.Any(e => e.ID == id);
        }
    }
}
