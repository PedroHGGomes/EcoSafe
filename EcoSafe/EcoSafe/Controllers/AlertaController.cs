using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcoSafe.Data;
using EcoSafe.Models;

namespace EcoSafe.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertaController : Controller
    {
        private readonly AppDbContext _context;

        public AlertaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ALERTA>>> GetAlertas()
        {
            return await _context.ALERTAS.Include(a => a.ABRIGO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ALERTA>> GetAlerta(int id)
        {
            var alerta = await _context.ALERTAS.Include(a => a.ABRIGO).FirstOrDefaultAsync(a => a.ID_ALERTA == id);
            if (alerta == null) return NotFound();
            return alerta;
        }

        [HttpGet("byAbrigo/{idAbrigo}")]
        public async Task<ActionResult<IEnumerable<ALERTA>>> GetByAbrigo(int idAbrigo)
        {
            return await _context.ALERTAS.Where(a => a.ID_ABRIGO == idAbrigo).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ALERTA>> PostAlerta(ALERTA alerta)
        {
            _context.ALERTAS.Add(alerta);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAlerta), new { id = alerta.ID_ALERTA }, alerta);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlerta(int id)
        {
            var alerta = await _context.ALERTAS.FindAsync(id);
            if (alerta == null) return NotFound();
            _context.ALERTAS.Remove(alerta);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

