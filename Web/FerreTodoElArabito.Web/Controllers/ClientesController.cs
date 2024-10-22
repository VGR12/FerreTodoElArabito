using FT.Lib.Data.Dal;
using FT.Lib.Data.Models.Filtro;
using Microsoft.AspNetCore.Mvc;

namespace FerreTodoElArabito.Web.Controllers
{
    public class ClientesController : Controller
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
        [Route("/Clientes")]
        public async Task<IActionResult> Clientes()
        {
            using var instance = new FerreTodoDal();
            ViewBag.Filtro = new FiltroClientes();
            var model = await instance.ObtenerClientes();
            return View(model);
        }

        [HttpPost]
        [Route("/Clientes/Obtener")]
        public IActionResult Listar([FromBody] FiltroClientes data)
        {
            using var instancia = new FerreTodoDal();
            ViewBag.Filtro = new FiltroClientes();
            //var resultado

            return Json(new { Mensaje = "EL MENSAJE ES EXITOSO", Status = "OK" });
        }
    }
}
