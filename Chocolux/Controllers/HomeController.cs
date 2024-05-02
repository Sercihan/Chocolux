using Chocolux.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chocolux.Controllers
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

        [Route("Hakkimizda")]
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Chocolate()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
