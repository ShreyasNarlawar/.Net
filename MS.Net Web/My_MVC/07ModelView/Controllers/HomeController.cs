using _07ModelView.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07ModelView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ProductViewModel model = new ProductViewModel()
            {
                Product = new Product() { Id = 11, Name = "Gold Biscuit[1000gm]", Price = 7185400 },
                categoryName = "Jewellary",
                isInStock = true,
                Message = "24k Gold.."
            };
            return View(model);
        }
        public IActionResult Test(Product p)
        {
            return View(p);
        }
        public IActionResult ProductDetails(int id)
        {
            Product p = new Product() { Id = 11, Name = "Gold Biscuit[1000gm]", Price = 7185400 };
            return View(p);
        }
    }
}
