using Microsoft.AspNetCore.Mvc;

namespace EVChargingPlatform.Controllers
{
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
