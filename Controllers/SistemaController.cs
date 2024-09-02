using Microsoft.AspNetCore.Mvc;

namespace FerreTodoElArabito.Web.Controllers
{
    public class SistemaController : Controller
    {
        public IActionResult Login(Guid token)
        {
            return View();
        }
        
        public IActionResult Registrar()
        {
            return View();
        }
        
        public IActionResult Recuperar()
        {
            return View();
        }

    }
}
