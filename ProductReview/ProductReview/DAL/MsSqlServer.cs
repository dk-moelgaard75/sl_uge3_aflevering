using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using ProductReview.Models;
using ProductReview.Utility;

namespace ProductReview.DAL
{
    public class MsSqlServer : IDBParser
    {
        DataTable IDBParser.GetData()
        {
            throw new NotImplementedException();
        }
        public void StoreData(ProductReviewModel productReviewModel)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            String sql = @"INSERT INTO productreview (reviewid,name,product,score) VALUES (@reviewId,@name,@product,@score)";
            SqlCommand dbCommand = new SqlCommand(sql, conn);
            dbCommand.Parameters.AddWithValue("@reviewId", productReviewModel.id);
            dbCommand.Parameters.AddWithValue("@name", productReviewModel.Name);
            dbCommand.Parameters.AddWithValue("@product", productReviewModel.Product);
            dbCommand.Parameters.AddWithValue("@score", productReviewModel.ProductScore);
            dbCommand.ExecuteNonQuery();
        }

        private string _connString = null;
        
        private String ConnectionString
        {
            get
            {
                if (_connString == null)
                {
                    string key = "mssql:connectionstring";
                    _connString = AppConfigUtil.GetKey(key); //configuration[key];
                }
                return _connString;
            }

        }
        private SqlConnection GetConnection()
        {
            var tmpConString = ConnectionString;
            return new SqlConnection(tmpConString);
        }
        private DataTable retrieveData()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from productreview";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();
            return dataTable;
        }
    }
}
