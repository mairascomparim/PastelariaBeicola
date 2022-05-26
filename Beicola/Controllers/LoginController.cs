using Microsoft.AspNetCore.Mvc;

namespace Beicola.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
