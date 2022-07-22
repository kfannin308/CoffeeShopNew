using CoffeeShopNew.Data;
using CoffeeShopNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopNew.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CoffeeShopNewContext _coffeeShopNewContext;

       
        public HomeController(ILogger<HomeController> logger, CoffeeShopNewContext newCoffeeShopNewContext)
        {
            _logger = logger;
            _coffeeShopNewContext = newCoffeeShopNewContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Summary(string firstName, string lastName, string email, string password, string coffee, string ageRange)
        {
            ViewData["firstName"] = firstName;
            ViewData["lastName"] = lastName;
            ViewData["email"] = email;
            ViewData["password"] = password;
            ViewData["coffee"] = coffee;
            ViewData["ageRange"] = ageRange;
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