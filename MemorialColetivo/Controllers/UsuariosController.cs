using MemorialColetivo.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MemorialColetivo.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Usuario.ToList();
            return View();
        }
    }
}
