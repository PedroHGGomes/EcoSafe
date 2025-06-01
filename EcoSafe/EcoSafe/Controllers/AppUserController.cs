using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcoSafe.Data;
using EcoSafe.Models;

namespace EcoSafe.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppUserController : Controller
    {
        private readonly AppDbContext _context;

        public AppUserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<APPUSER>>> GetUsers()
        {
            return await _context.APPUSERS.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<APPUSER>> GetUser(int id)
        {
            var user = await _context.APPUSERS.FindAsync(id);
            if (user == null) return NotFound();
            return user;
        }

        [HttpPost]
        public async Task<ActionResult<APPUSER>> PostUser(APPUSER user)
        {
            _context.APPUSERS.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUser), new { id = user.ID_USUARIO }, user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, APPUSER user)
        {
            if (id != user.ID_USUARIO) return BadRequest();
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.APPUSERS.FindAsync(id);
            if (user == null) return NotFound();
            _context.APPUSERS.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

