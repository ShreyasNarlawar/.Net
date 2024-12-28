using _10TagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace _10TagHelper.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult<string> GetUserDetails(User user)
        {
            if (ModelState.IsValid)
            {
                string details = $"Name:{user.Name},Address:{user.Address},Age: {user.Age},Gender: {user.Gender},Mobile: {user.PhNo},Email:{user.Email},Marital Status:{user.IsMarried},Enquiry:{user.Enquiry}";
                return details;
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
