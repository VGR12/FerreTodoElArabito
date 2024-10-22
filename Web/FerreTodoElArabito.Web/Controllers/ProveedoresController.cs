using FT.Lib.Data.Dal;
using FT.Lib.Data.Models.Filtro;
using Microsoft.AspNetCore.Mvc;

namespace FerreTodoElArabito.Web.Controllers
{
    public class ProveedoresController : Controller
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
        [Route("/Proveedores")]
        public async Task<IActionResult> Proveedores()
        {
            using var instance = new FerreTodoDal();
            ViewBag.Filtro = new FiltroProveedores();
            var model = await instance.ObtenerProveedores();
            return View(model);
        }

        [HttpPost]
        [Route("/Proveedores/Obtener")]
        public IActionResult Listar([FromBody] FiltroProveedores data)
        {
            using var instancia = new FerreTodoDal();
            ViewBag.Filtro = new FiltroProveedores();
            //var resultado

            return Json(new { Mensaje = "EL MENSAJE ES EXITOSO", Status = "OK" });
        }
    }
}
