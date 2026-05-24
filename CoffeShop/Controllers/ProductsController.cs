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

        public ActionResult Shop()
        {
            return View(productRepository.GetProducts());
        }

        public IActionResult Detail(int id)
        {
            // Tìm sản phẩm theo ID từ Repository
            var product = productRepository.GetProductDetail(id);

            // Nếu tìm thấy sản phẩm, trả về View cùng dữ liệu sản phẩm đó
            if (product != null)
            {
                return View(product);
            }

            // Nếu không thấy (ID sai), trả về trang lỗi 404
            return NotFound();
        }
    }
}
