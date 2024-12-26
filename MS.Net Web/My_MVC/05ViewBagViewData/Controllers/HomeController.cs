using _05ViewBagViewData.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05ViewBagViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string[] days = new string[]
            {
                "monday","friday","sunday"
            };
            ViewData["Weekdays"] = days;

            Emp emp = new Emp() { Id=11,Name = "Raju",Address = "Nagpur" };
            //ViewBag.Key  = Value;
            ViewBag.EmpData = emp;
            TempData["Message"] = "Hello";
            return View();
        }
        public IActionResult About()
        {
            //ViewBag used ViewData internally.
            //Hence can not keep keys same for both the types
            ViewData["Msg"] = "Hi";
            ViewBag.Msg = "Bye";
            return View();
        }
    }
    
}
