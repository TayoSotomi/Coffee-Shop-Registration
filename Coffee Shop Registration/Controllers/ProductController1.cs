using Coffee_Shop_Registration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_Registration.Controllers
{
    public class ProductController1 : Controller
    {
        private CoffeeDbContext dbContext = new CoffeeDbContext();
        public IActionResult Index()
        {
            return View(ProductDAL.GetAll());
        }
        public IActionResult Detail(int Id)
        {
            return View(ProductDAL.GetById(Id));
        }
        public IActionResult Categories()
        {
            return View(ProductDAL.GetAllCategories());
        }
        public IActionResult ProductsByCategory(string category)
        {
            return View(ProductDAL.GetByCategory(category));
        }
    }
}
