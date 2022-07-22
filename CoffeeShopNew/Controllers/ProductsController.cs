using Microsoft.AspNetCore.Mvc;
using CoffeeShopNew.Data;
using CoffeeShopNew.Models;

namespace CoffeeShopNew.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CoffeeShopNewContext _coffeeShopNewContext;

        public ProductsController(ILogger<HomeController> logger, CoffeeShopNewContext newCoffeeShopNewContext)
        {
            _logger = logger;
            _coffeeShopNewContext = newCoffeeShopNewContext;
        }

        public IActionResult Index()
        {
            var productList = _coffeeShopNewContext.Products.ToArray();
            return View(productList);
        }
        public IActionResult Details(int productId)
        {
            Products theProduct = null;
            var productList = _coffeeShopNewContext.Products.ToArray();
            foreach (var curr in productList)
            {
                if (curr.Id == productId)
                {
                    theProduct = curr;
                    break;
                }
            }
            return View(theProduct);
        }
    }
}
