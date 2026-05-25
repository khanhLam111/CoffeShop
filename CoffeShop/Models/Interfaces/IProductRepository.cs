using CoffeShop.Models;

namespace CoffeShop.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product? GetProductDetail(int id);
        IEnumerable<Product> GetTrendingProducts();
    }
}

