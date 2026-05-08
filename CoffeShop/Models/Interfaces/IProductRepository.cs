using System.Collections.Generic;
using coffeeshop.Data;
using coffeeshop.Models;

namespace coffeeshop.Models.interfaces // Chú ý: viết thường
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product? GetProductDetail(int id);
        IEnumerable<Product> GetTrendingProducts();
    }
}
