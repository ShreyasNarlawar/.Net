
using _09ActionResultFilter.Filters;
using Microsoft.AspNetCore.Mvc;

namespace _09ActionResultFilter.Controllers
{
    [ServiceFilter(typeof(LoggingActionFilter))]
    [ServiceFilter(typeof(DynamicLayoutFilter))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
