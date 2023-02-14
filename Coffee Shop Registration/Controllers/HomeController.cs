using Coffee_Shop_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Coffee_Shop_Registration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Allow access to the DB
        private CoffeeDbContext dbContext = new CoffeeDbContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //grabbing all products
            List<Product> result = dbContext.Products.ToList();
            return View(result);
        }
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult ProductDetails(int Id)
        {
            Product result = dbContext.Products.Find(Id);
            return View(result);
        }
        public IActionResult Result(NewUser N)
        {
            return View(N);
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