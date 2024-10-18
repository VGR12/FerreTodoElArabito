using FT.Lib.Data.Dal;
using FT.Lib.Data.Models.Filtro;
using FT.Lib.Data.Models.Inventario;
using Microsoft.AspNetCore.Mvc;

namespace FerreTodoElArabito.Web.Controllers
{
    public class InventarioController : Controller
    {
        [HttpGet]
        [Route("/Inventario/Agregar")]
        public async Task<IActionResult> AgregarProducto(Guid? token)
        {
            if (token.HasValue)
            {


                return PartialView();
            }
            return View();
        }

        [HttpGet]
        [Route("/Inventario")]
        public async Task<IActionResult> Inventario()
        {
            using var instance = new FerreTodoDal();
            ViewBag.Filtro = new FiltroInventario();
            var model = await instance.ObtenerInventario(new FiltroInventario());
            return View();
        }

        [HttpPost]
        [Route("/Inventario/Obtener")]
        public async Task<IActionResult> Listar([FromBody] FiltroInventario data)
        {
            using var instancia = new FerreTodoDal();
            ViewBag.Filtro = new FiltroInventario();
            //var resultado

            return Json(new { Mensaje = "EL MENSAJE ES EXITOSO", Status = "OK" });
        }
    }
}
