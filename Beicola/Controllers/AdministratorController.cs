using Microsoft.AspNetCore.Mvc;

namespace Beicola.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
