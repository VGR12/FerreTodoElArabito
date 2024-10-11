using Microsoft.AspNetCore.Mvc;

namespace FerreTodoElArabito.Web.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
