using FT.Lib.Data.Dal;
using FT.Lib.Data.Models.Filtro;
using Microsoft.AspNetCore.Mvc;

namespace FerreTodoElArabito.Web.Controllers
{
    public class UsuariosController : Controller
    {

        [HttpGet]
        [Route("/Usuarios")]
        public IActionResult Usuarios()
        {
            using var instance = new FerreTodoDal();
            ViewBag.Filtro = new FiltroUsuario();
            //var model = await instance.ObtenerInventario(new FiltroInventario());
            return View();
        }
    }
}
