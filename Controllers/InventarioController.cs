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
        [Route("/Inventario")]
        public IActionResult Inventario()
        {

            return View();
        }

        [HttpGet]
        [Route("/ObtenerInventario")]
        public IActionResult Listar()
        {
            return View();
        }
    }
}
