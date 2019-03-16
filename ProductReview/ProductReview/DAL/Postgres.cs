using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ProductReview.Models;

namespace ProductReview.DAL
{
    public class Postgres : IDBParser
    {
        DataTable IDBParser.GetData()
        {
            throw new NotImplementedException();
        }

        void IDBParser.StoreData(ProductReviewModel productReviewModel)
        {
            throw new NotImplementedException();
        }
    }
}
