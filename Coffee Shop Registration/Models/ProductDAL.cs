using System.Runtime.CompilerServices;

namespace Coffee_Shop_Registration.Models
{
    public class ProductDAL
    {
        static CoffeeDbContext dbContext = new CoffeeDbContext();

        public static List<Product> GetAll()
        {

            return dbContext.Products.ToList();
        }
        public static Product GetById(int Id)
        {
            return dbContext.Products.Find(Id);
        }
        public static List<Product>GetByCategory(string category)
        {
            return dbContext.Products.Where(p=>p.Category.ToLower().Trim() == category.ToLower().Trim()).ToList();
        }
        public static List<string> GetAllCategories()
        {
            return dbContext.Products.GroupBy(p => p.Category).ToDictionary(x => x.Key, y => y).Keys.ToList();
        }
    }
}
