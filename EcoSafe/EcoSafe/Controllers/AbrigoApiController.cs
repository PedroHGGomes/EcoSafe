using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcoSafe.Data;
using EcoSafe.Models;

namespace EcoSafe.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AbrigoApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AbrigoApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ABRIGO>>> GetAbrigos()
        {
            var abrigos = await _context.ABRIGOS
                .Include(a => a.SENSORES)
                .Include(a => a.ALERTAS)
                .ToListAsync();

            return Ok(abrigos); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ABRIGO>> GetAbrigo(int id)
        {
            var abrigo = await _context.ABRIGOS
                .Include(a => a.SENSORES)
                .Include(a => a.ALERTAS)
                .FirstOrDefaultAsync(a => a.ID_ABRIGO == id);

            if (abrigo == null)
                return NotFound();

            return Ok(abrigo);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<ABRIGO>>> SearchByName([FromQuery] string nome)
        {
            var resultados = await _context.ABRIGOS
                .Where(a => a.NOME.ToUpper().Contains(nome.ToUpper()))
                .ToListAsync();

            if (!resultados.Any())
                return NotFound(); 

            return Ok(resultados);
        }

        [HttpPost]
        public async Task<ActionResult<ABRIGO>> PostAbrigo(ABRIGO abrigo)
        {
            _context.ABRIGOS.Add(abrigo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAbrigo), new { id = abrigo.ID_ABRIGO }, abrigo); 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAbrigo(int id, ABRIGO abrigo)
        {
            if (id != abrigo.ID_ABRIGO)
                return BadRequest();

            _context.Entry(abrigo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.ABRIGOS.Any(a => a.ID_ABRIGO == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbrigo(int id)
        {
            var abrigo = await _context.ABRIGOS.FindAsync(id);
            if (abrigo == null)
                return NotFound(); 

            _context.ABRIGOS.Remove(abrigo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

