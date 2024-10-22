using FT.Lib.Data.Dal;
using FT.Lib.Data.Models.Filtro;
using FT.Lib.Data.Models.CuentasPorPagar;
using Microsoft.AspNetCore.Mvc;


namespace FerreTodoElArabito.Web.Controllers
{
    public class CuentasPorPagarController : Controller
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
        [Route("/CuentasPorPagar")]
        public async Task<IActionResult> CuentasPorPagar()
        {
            using var instance = new FerreTodoDal();
            ViewBag.Filtro = new FiltroCuentasPorPagar();
            var model = await instance.ObtenerCuentasPorPagar();
            return View(model);
        }

        [HttpPost]
        [Route("/CuentasPorPagar/Obtener")]
        public IActionResult Listar([FromBody] FiltroCuentasPorPagar data)
        {
            using var instancia = new FerreTodoDal();
            ViewBag.Filtro = new FiltroCuentasPorPagar();
            //var resultado

            return Json(new { Mensaje = "EL MENSAJE ES EXITOSO", Status = "OK" });
        }
    }
}
