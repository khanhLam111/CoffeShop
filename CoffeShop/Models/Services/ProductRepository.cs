using coffeeshop.Data;
using coffeeshop.Models.interfaces;

namespace coffeeshop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly CoffeeshopDbContext dbContext;

        public ProductRepository(CoffeeshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct).ToList();
        }

     

       
    }
}