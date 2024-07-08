using Hospital_API.Context;
using Hospital_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public DepartamentosController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Departamentoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Departamento>>> GetDepartamentos()
        {
            return await _context.Departamentos.ToListAsync();
        }

        // GET: api/Departamentoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Departamento>> GetDepartamento(int id)
        {
            var departamento = await _context.Departamentos.FindAsync(id);

            if (departamento == null)
            {
                return NotFound();
            }

            return departamento;
        }

        // PUT: api/Departamentoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartamento(int id, Departamento departamento)
        {
            if (id != departamento.ID)
            {
                return BadRequest();
            }

            _context.Entry(departamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartamentoExists(id))
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

        // POST: api/Departamentoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Departamento>> PostDepartamento(Departamento departamento)
        {
            _context.Departamentos.Add(departamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartamento", new { id = departamento.ID }, departamento);
        }

        // DELETE: api/Departamentoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartamento(int id)
        {
            var departamento = await _context.Departamentos.FindAsync(id);
            if (departamento == null)
            {
                return NotFound();
            }

            _context.Departamentos.Remove(departamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepartamentoExists(int id)
        {
            return _context.Departamentos.Any(e => e.ID == id);
        }
    }
}
