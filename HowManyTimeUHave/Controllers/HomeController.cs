
using HowManyTimeUHave.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HowManyTimeUHave.Controllers
{
    public class HomeController : Controller
    {
        /*
        public string mAge { set; get; }
        public string fAge { set; get; }
        public string aCnt { set; get; }
        public string country { set; get; }
        */

        private readonly ILogger<HomeController> _logger;


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public string PostUsingParametrs(String mAge, string fAge, string aCnt , string Country)
        {
            return "Mother Age: " + mAge + "Father Age" + fAge;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}