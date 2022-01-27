
using HowManyTimeUHave.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;

namespace HowManyTimeUHave.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;


        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        /*
       [HttpPost]
       public string PostUsingRequest()
       {
           string mAge = Request["mAge"];
           string fAge = Request["fAge"];
           string aCnt = Request["aCnt"];

           return " From Request " + mAge;
       }
        */
        

  
        [HttpPost]
       public string PostUsingParametrs(string mAge, string fAge, string aCnt )
       {

            int mAgee = Convert.ToInt32(mAge);
            int fAgee = Convert.ToInt32(fAge);
            int aCntt = Convert.ToInt32(aCnt);
           

            int lowerage;

            if (aCntt <= 0)
                return " Przykro mi to mówić ale już ich nie zobaczysz";

            

            if (mAgee < 0 || fAgee < 0)
                return " Dane źle wprowadzone";


            if (mAgee == 0 || fAgee == 0)
            {

                if (mAgee == 0)
                {
                    return "Spotkasz się z tatą jeszcze: " + mAgee + " razy";
                }
                else if (fAgee == 0)

                {
                    return "Spotkasz się z mamą jeszcze: " + mAgee + " razy";
                }
            }

            if(mAgee > fAgee)
            {
                lowerage = (mAgee) * aCntt;
                return " Spotkasz się z rodzicami jeszcze" + lowerage + " razy";
            }
            else
            {
                lowerage = (fAgee) * aCntt;
                return " Spotkasz się z rodzicami jeszcze" + lowerage + " razy";

            }
            


            
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