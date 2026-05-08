
using coffeeshop.Models.interfaces;

using Microsoft.AspNetCore.Mvc;

namespace coffeeshop.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public ActionResult Shop() {
            return View(productRepository.GetProducts());
        }
         
    }
}
