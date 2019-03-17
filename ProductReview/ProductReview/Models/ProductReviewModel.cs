using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReview.Models
{
    public class ProductReviewModel
    {
        public Guid _id;
        public Guid id
        {
            //Lazy loading
            get
            {
                if (_id == Guid.Empty)
                {
                    _id = Guid.NewGuid();
                }
                return _id;
            }
        }
        public string Name { get; set; }
        public string Product { get; set; }
        public int ProductScore { get; set; }
        public void ClearModel()
        {
            Name = "";
            Product = "";
            ProductScore = 0;
            _id = Guid.Empty;
        }
    }
}
