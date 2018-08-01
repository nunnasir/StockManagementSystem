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
    public class StockOutRepository
    {
        Connection connection = new Connection();

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

        //Load Items
        public DataTable LoadItem(StockOut stockOut)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"SELECT * FROM Items WHERE CategoryId = " + stockOut.CategoryId + " AND CompanyId = " + stockOut.CompanyId + " ";
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
