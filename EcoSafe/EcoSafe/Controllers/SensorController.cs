﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcoSafe.Data;
using EcoSafe.Models;

namespace EcoSafe.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SensorController : Controller
    {
        private readonly AppDbContext _context;

        public SensorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SENSOR>>> GetSensores()
        {
            return await _context.SENSORES.Include(s => s.ABRIGO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SENSOR>> GetSensor(int id)
        {
            var sensor = await _context.SENSORES.Include(s => s.ABRIGO).FirstOrDefaultAsync(s => s.ID_SENSOR == id);
            if (sensor == null) return NotFound();
            return sensor;
        }

        [HttpGet("byAbrigo/{idAbrigo}")]
        public async Task<ActionResult<IEnumerable<SENSOR>>> GetByAbrigo(int idAbrigo)
        {
            return await _context.SENSORES.Where(s => s.ID_ABRIGO == idAbrigo).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<SENSOR>> PostSensor(SENSOR sensor)
        {
            _context.SENSORES.Add(sensor);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSensor), new { id = sensor.ID_SENSOR }, sensor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSensor(int id, SENSOR sensor)
        {
            if (id != sensor.ID_SENSOR) return BadRequest();
            _context.Entry(sensor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSensor(int id)
        {
            var sensor = await _context.SENSORES.FindAsync(id);
            if (sensor == null) return NotFound();
            _context.SENSORES.Remove(sensor);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

