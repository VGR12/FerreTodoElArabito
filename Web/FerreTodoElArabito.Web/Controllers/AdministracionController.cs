using Microsoft.AspNetCore.Mvc;

namespace FerreTodoElArabito.Web.Controllers
{
    public class AdministracionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
