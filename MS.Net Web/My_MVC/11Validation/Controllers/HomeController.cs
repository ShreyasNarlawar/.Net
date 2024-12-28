using _11Validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _11Validation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(User user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("Index", user);
            }
        }
        public IActionResult Privacy() 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() 
        {
            return View(new ErrorViewModel{RequestId =
            Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
