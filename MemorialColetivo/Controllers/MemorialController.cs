using MemorialColetivo.Data;
using MemorialColetivo.Data.Services;
using MemorialColetivo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MemorialColetivo.Controllers
{
    public class MemorialController : Controller
    {
        private readonly IMemorialService _service;

        public MemorialController(IMemorialService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        //Get: Memorial/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,MemorialPictureURL,Historia,DataFalecimento,Formacao,Religiao,Hobbies")]Memorial memorial)
        {
            if(ModelState.IsValid)
            {
                return View(memorial);
            }
            _service.Add(memorial);
            return RedirectToAction(nameof(Index));
        }
    }
}
