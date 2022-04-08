using Microsoft.AspNetCore.Mvc;
using saja_festival.Models;
using System.Diagnostics;
using MySql.Data;

namespace saja_festival.Controllers
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
        
        [Route ("contact")]
        public IActionResult Contact(string Voornaam, string Achternaam)
        {
            ViewData["firstname"] = Voornaam; 
            ViewData["lastname"] = Achternaam;

            return View();
        }

        [Route ("privacy")]
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