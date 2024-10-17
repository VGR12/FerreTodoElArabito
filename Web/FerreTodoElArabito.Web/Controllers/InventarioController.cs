using FT.Lib.Data.Dal;
using FT.Lib.Data.Models.Filtro;
using FT.Lib.Data.Models.Inventario;
using Microsoft.AspNetCore.Mvc;

namespace FerreTodoElArabito.Web.Controllers
{
    public class InventarioController : Controller
    {
        [HttpGet]
        [Route("/Agregar")]
        public async Task<IActionResult> Agregar(Guid? token)
        {
            if (token.HasValue)
            {

            }
            return View();
        }

        [HttpGet]
        [Route("/Inventario")]
        public async Task<IActionResult> Inventario()
        {
            using var instance = new FerreTodoDal();
            ViewBag.Filtro = new FiltroInventario();
            var model = await instance.ObtenerInventario();
            return View(model);
        }

        [HttpPost]
        [Route("/Inventario/Obtener")]
        public IActionResult Listar([FromBody] FiltroInventario data)
        {
            using var instancia = new FerreTodoDal();
            ViewBag.Filtro = new FiltroInventario();
            //var resultado

            return Json( new {Mensaje="EL MENSAJE ES EXITOSO", Status="OK"});
        }
    }
}
