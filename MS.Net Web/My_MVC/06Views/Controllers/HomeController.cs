using _06Views.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace _06Views.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Emp emp = new Emp() { Id = 1 , Name ="lakshay", Address="Kanpur"};

            Cust cust = new Cust() { Id = 2,Name="Nitin", Address = "Pune" };

            ArrayList arr = new ArrayList() { emp, cust};
            return View(arr);
        }
    }
}
