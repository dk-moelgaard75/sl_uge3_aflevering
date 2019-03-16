using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using ProductReview.Models;


namespace ProductReview.DAL
{
    public interface IDBParser
    {
        DataTable GetData();
        void StoreData(ProductReviewModel productReviewModel);
    }
}
