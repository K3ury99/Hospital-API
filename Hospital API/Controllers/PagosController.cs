using Hospital_API.Context;
using Hospital_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public PagosController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Pagoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pago>>> GetPagos()
        {
            return await _context.Pagos.ToListAsync();
        }

        // GET: api/Pagoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pago>> GetPago(int id)
        {
            var pago = await _context.Pagos.FindAsync(id);

            if (pago == null)
            {
                return NotFound();
            }

            return pago;
        }

        // PUT: api/Pagoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPago(int id, Pago pago)
        {
            if (id != pago.ID)
            {
                return BadRequest();
            }

            _context.Entry(pago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagoExists(id))
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

        // POST: api/Pagoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pago>> PostPago(Pago pago)
        {
            _context.Pagos.Add(pago);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPago", new { id = pago.ID }, pago);
        }

        // DELETE: api/Pagoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePago(int id)
        {
            var pago = await _context.Pagos.FindAsync(id);
            if (pago == null)
            {
                return NotFound();
            }

            _context.Pagos.Remove(pago);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PagoExists(int id)
        {
            return _context.Pagos.Any(e => e.ID == id);
        }
    }
}
