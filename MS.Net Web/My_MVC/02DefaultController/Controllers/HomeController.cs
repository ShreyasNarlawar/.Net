using _02DefaultController.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _02DefaultController.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
    }
}
