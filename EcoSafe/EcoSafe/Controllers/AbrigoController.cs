using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcoSafe.Data;
using EcoSafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcoSafe.Controllers
{
    public class AbrigoController : Controller
    {
        private readonly AppDbContext _context;

        public AbrigoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var abrigos = await _context.ABRIGOS.ToListAsync();
            return View(abrigos);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ABRIGO abrigo)
        {
            if (ModelState.IsValid)
            {
                _context.ABRIGOS.Add(abrigo);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Abrigo cadastrado com sucesso!";
                return RedirectToAction(nameof(Index)); 
            }
            return View(abrigo);
        }



    }
}

