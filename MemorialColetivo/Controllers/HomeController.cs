using Microsoft.AspNetCore.Mvc;

namespace MemorialColetivo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
