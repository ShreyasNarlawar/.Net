using Microsoft.AspNetCore.Mvc;

namespace _03AttributeBasedRouting.Controllers
{
    [Route("[controller]")] //Tokens
    public class UserController : Controller
    {
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[action]/{id?}")]
        public int GetNumber(int? id)
        {
            return id ??= 555;
        }
    }
}
