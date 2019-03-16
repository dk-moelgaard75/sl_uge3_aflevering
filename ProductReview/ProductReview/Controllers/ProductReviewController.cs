using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductReview.Services;
using ProductReview.Models;

namespace ProductReview.Controllers
{
    public class ProductReviewController : Controller
    {
        private IProductReviewService _productReviewService;
        public ProductReviewController(IProductReviewService productReviewService)
        {
            _productReviewService = productReviewService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ProductReviewModel productReviewModel)
        {
            await _productReviewService.RegisterReview(productReviewModel);
            return Content($"Product {productReviewModel.Product} with score {productReviewModel.ProductScore} stored");
        }
    }
}