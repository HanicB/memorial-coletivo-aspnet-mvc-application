using MemorialColetivo.Data;
using MemorialColetivo.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MemorialColetivo.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuariosService _service;
        public UsuariosController(IUsuariosService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.getAll();
            return View(data);
        }
    }
}
