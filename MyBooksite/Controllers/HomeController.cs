using Microsoft.AspNetCore.Mvc;
using MyBooksite.Models;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MyBooksite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {

            return View();
        }
        public IActionResult table()
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
