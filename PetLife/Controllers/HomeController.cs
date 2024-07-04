using Microsoft.AspNetCore.Mvc;
using PetLife.Models;
using System.Diagnostics;

namespace PetLife.Controllers
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

        public IActionResult ForUs()
        {
            return View("ForUs");
        }

        public IActionResult Contacts()
        {
            return View("Contacts");
        }

        public IActionResult ImportantInformation()
        {
            return View("ImportantInformation");
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
