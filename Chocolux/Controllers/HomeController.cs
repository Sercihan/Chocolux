using Chocolux.Models;
using Chocolux.ORM.Context;
using Chocolux.ORM.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chocolux.Controllers
{
    public class HomeController : Controller
    {

        DataContext db = new DataContext();
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
            List<Chocolate> chocolates = db.Chocolates.ToList();
            return View(chocolates);
        }

        public IActionResult Testimonial()
        {
            List<Employee> employees = db.Employees.ToList();
            return View(employees);
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
