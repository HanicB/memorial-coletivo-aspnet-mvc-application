using MemorialColetivo.Data;
using MemorialColetivo.Data.Services;
using MemorialColetivo.Models;
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
            var data = await _service.GetAll();
            return View(data);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var usuario = await _service.GetById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        [HttpPost]
        public IActionResult Edit(int id, Usuario usuario)
        {
            if (id != usuario.UsuarioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _service.Update(id, usuario);
                return RedirectToAction(nameof(Index));
            }

            return View(usuario);
        }

        public async Task<IActionResult> Details(int id)
        {
            var usuario = await _service.GetById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var usuario = await _service.GetById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
