
using CoffeShop.Models;

using Microsoft.AspNetCore.Mvc;
using CoffeShop.Models.Interfaces;
namespace CoffeShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ActionResult Shop()
        {
            return View(productRepository.GetProducts());
        }

        public IActionResult Detail(int id)
        {
            var product = productRepository.GetProductDetail(id);

            if (product != null)
            {
                return View(product);
            }

            return NotFound();
        }
    }
}
