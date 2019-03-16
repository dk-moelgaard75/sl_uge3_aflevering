using System.Threading.Tasks;
using ProductReview.Models;

namespace ProductReview.Services
{
    public interface IProductReviewService
    {
        Task<bool> RegisterReview(ProductReviewModel productReviewModel);
    }
}