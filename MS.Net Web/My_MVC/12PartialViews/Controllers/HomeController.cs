using _12PartialViews.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _12PartialViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> productlist = new List<Product>()
            {
                new Product() {Id = 1, Name="Laptop", Description="Gaming", Image="~/images/Laptop.jpeg",Price=100000},
                new Product() {Id = 1, Name="Laptop", Description="Gaming", Image="~/images/Laptop.jpeg",Price=80000},
                new Product() {Id = 1, Name="Laptop", Description="Gaming", Image="~/images/Laptop.jpeg",Price=50000}
            };

            return View(productlist);
        }

        public IActionResult About()
        {
            return View();
        }

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
