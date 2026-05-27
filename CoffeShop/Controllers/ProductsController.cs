
using CoffeShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly CoffeeshopDbContext _context;

        public ProductsController(CoffeeshopDbContext context)
        {
            _context = context;
        }

        // Trang danh sách Shop
        public IActionResult Shop()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        // Trang chi tiết sản phẩm
        public IActionResult Detail(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}