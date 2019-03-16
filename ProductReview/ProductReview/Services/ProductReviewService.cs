using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductReview.Models;
using ProductReview.DAL;

namespace ProductReview.Services
{
    public class ProductReviewService : IProductReviewService
    {
        public Task<bool> RegisterReview(ProductReviewModel productReviewModel)
        {
            DALFactory.GetDbParser().StoreData(productReviewModel);
            return Task.FromResult(true);
        }
    }
}
