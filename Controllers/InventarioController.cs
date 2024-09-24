using Microsoft.AspNetCore.Mvc;

namespace FerreTodoElArabito.Web.Controllers
{
    public class InventarioController : Controller
    {
        [HttpGet]
        [Route("/Agregar")]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpGet]
        [Route("/Listar")]
        public IActionResult Listar()
        {
            return View();
        }
    }
}
