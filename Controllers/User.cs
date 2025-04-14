using Microsoft.AspNetCore.Mvc;

namespace EVChargingPlatform.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
