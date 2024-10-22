using FT.Lib.Data.Dal;
using FT.Lib.Data.Models.Filtro;
using FT.Lib.Data.Models.CuentasPorCobrar;
using Microsoft.AspNetCore.Mvc;

namespace FerreTodoElArabito.Web.Controllers
{
    public class CuentasPorCobrarController : Controller
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
        [Route("/CuentasPorCobrar")]
        public async Task<IActionResult> CuentasPorCobrar()
        {
            using var instance = new FerreTodoDal();
            ViewBag.Filtro = new FiltroCuentasPorCobrar();
            var model = await instance.ObtenerCuentasPorCobrar();
            return View(model);
        }

        [HttpPost]
        [Route("/CuentasPorCobrar/Obtener")]
        public IActionResult Listar([FromBody] FiltroCuentasPorCobrar data)
        {
            using var instancia = new FerreTodoDal();
            ViewBag.Filtro = new FiltroCuentasPorCobrar();
            //var resultado

            return Json(new { Mensaje = "EL MENSAJE ES EXITOSO", Status = "OK" });
        }
    }
}
