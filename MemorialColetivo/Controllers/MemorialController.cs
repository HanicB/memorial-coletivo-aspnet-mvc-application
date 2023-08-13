using MemorialColetivo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MemorialColetivo.Controllers
{
    public class MemorialController : Controller
    {
        private readonly AppDbContext _context;

        public MemorialController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Memorial.ToListAsync();
            return View(allMovies);
        }
    }
}
