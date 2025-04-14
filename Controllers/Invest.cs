using Microsoft.AspNetCore.Mvc;

namespace EVChargingPlatform.Controllers
{
    public class InvestController : Controller
    {
        [HttpGet]
        public IActionResult Index(int stationId)
        {
            ViewBag.StationId = stationId;
            return View();
        }

        [HttpPost]
        public IActionResult SubmitInvestment(int stationId, int amount)
        {
            // Burada veritabanına yatırım kaydedilebilir
            ViewBag.StationId = stationId;
            ViewBag.Amount = amount;
            return View("InvestmentSuccess");
        }
    }
}
