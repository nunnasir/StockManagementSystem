using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;

namespace StockManagementSystem.DAL
{
    public class SearchRepository
    {
        Connection connection = new Connection();
        //Search search = new Search();

        //Load Company
        public DataTable LoadCompany()
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"SELECT * FROM Company";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sd = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sd);
            conn.Close();
            return dt;
        }

        //Load Category
        public DataTable LoadCategory()
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"SELECT * FROM Category";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sd = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sd);
            conn.Close();
            return dt;
        }

        //Load search Item on Grid vie
        public DataTable LoadSearchItem(Search search)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"SELECT it.Name ItemName, co.Name CompanyName, ct.Name CategoryName, iv.Quantity Quantity, iv.Reorder Reorder FROM Items it LEFT OUTER JOIN Company co  ON it.CompanyId = co.Id LEFT OUTER JOIN Category ct ON it.CategoryId = ct.Id LEFT OUTER JOIN Inventory iv ON it.Id = iv.ItemId WHERE co.Id = "+search.CompanyId+" AND ct.Id = "+search.CategoryId+" ";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sd = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sd);
            conn.Close();
            return dt;
        }

    }
}
