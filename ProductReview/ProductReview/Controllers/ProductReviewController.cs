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
            ViewData["Result"] = "Product hasn´t been reviewed";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ProductReviewModel productReviewModel)
        {
            await _productReviewService.RegisterReview(productReviewModel);
            ViewData["Result"] = $"Product {productReviewModel.Product} with score {productReviewModel.ProductScore} stored";
            //Trying to empty model, but I´m missing some sort of signal to the webpage, to do an update
            productReviewModel.ClearModel();
            return View(productReviewModel);
        }

    }
}