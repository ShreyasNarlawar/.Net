using Microsoft.AspNetCore.Mvc;

namespace _04ActionMethodReturnTypes.Controllers
{
    public class HomeController : Controller
    {
        //Most Flexible Return type
        public IActionResult Index()
        {
            return View();
        }

        //Strongly Typed responses
        public ActionResult<string> GetName(string name, string surname)
        {
            string str = $"Name: {name}, Surname : {surname}";
            return str;
        }

        public JsonResult GetJsonResult()
        {
            var data = new
            {
                Name = "Ganya",
                Address = "Pune",
                Courses = new[]
                {"C#","Java","C++"}
            };
            return Json(data);
        }

        public IActionResult About()
        {
            return View();
        }

        public FileResult DownloadFile()
        {
            var byteArray = System.IO.File.ReadAllBytes(@"D:\Shreyas\MS.NET\MS.Net Web\My_MVC\04ActionMethodReturnTypes\Data\quote.pdf");
            return File(byteArray, "application/pdf", "quote.pdf");
        }

        public EmptyResult empty()
        {
            return new EmptyResult();
        }

        public StatusCodeResult status()
        {
            return StatusCode(404);
        }

        public ObjectResult obj()
        {
            var obj = new { name = "Mahesh", Address = "Mumbai" };
            return new ObjectResult(obj);
        }

        [HttpGet("Home/GetDataAsync")]
        public async Task<IActionResult> GetDataAsync()
        {
            await Task.Delay(2000);
            return View("~/Views/Home/GetData.cshtml");
        }
    }
}
