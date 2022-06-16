using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        { 
            _config = config;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //string s = _config.GetConnectionString("PGHI");

            return View();
        }

        [HttpPost]
        public IActionResult Index(string myName, string myAge, string myCNIC)
        {
           var model = new ResultViewModel { Name = myName, Age=myAge, CNIC = myCNIC };
            return View(model);
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