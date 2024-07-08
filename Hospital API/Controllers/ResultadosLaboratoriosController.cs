using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital_API.Context;
using Hospital_API.Models;

namespace Hospital_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadosLaboratoriosController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ResultadosLaboratoriosController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/ResultadoLaboratorios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResultadoLaboratorio>>> GetResultadosLaboratorio()
        {
            return await _context.ResultadosLaboratorio.ToListAsync();
        }

        // GET: api/ResultadoLaboratorios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ResultadoLaboratorio>> GetResultadoLaboratorio(int id)
        {
            var resultadoLaboratorio = await _context.ResultadosLaboratorio.FindAsync(id);

            if (resultadoLaboratorio == null)
            {
                return NotFound();
            }

            return resultadoLaboratorio;
        }

        // PUT: api/ResultadoLaboratorios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResultadoLaboratorio(int id, ResultadoLaboratorio resultadoLaboratorio)
        {
            if (id != resultadoLaboratorio.ID)
            {
                return BadRequest();
            }

            _context.Entry(resultadoLaboratorio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultadoLaboratorioExists(id))
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

        // POST: api/ResultadoLaboratorios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ResultadoLaboratorio>> PostResultadoLaboratorio(ResultadoLaboratorio resultadoLaboratorio)
        {
            _context.ResultadosLaboratorio.Add(resultadoLaboratorio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResultadoLaboratorio", new { id = resultadoLaboratorio.ID }, resultadoLaboratorio);
        }

        // DELETE: api/ResultadoLaboratorios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResultadoLaboratorio(int id)
        {
            var resultadoLaboratorio = await _context.ResultadosLaboratorio.FindAsync(id);
            if (resultadoLaboratorio == null)
            {
                return NotFound();
            }

            _context.ResultadosLaboratorio.Remove(resultadoLaboratorio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResultadoLaboratorioExists(int id)
        {
            return _context.ResultadosLaboratorio.Any(e => e.ID == id);
        }
    }
}
