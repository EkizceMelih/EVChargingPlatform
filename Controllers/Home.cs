using Microsoft.AspNetCore.Mvc;

namespace EVChargingPlatform.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
