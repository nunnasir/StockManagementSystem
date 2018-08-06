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
    public class StockinRepository
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
        public DataTable LoadItem(Stockin stockin)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"SELECT * FROM Items WHERE CategoryId = "+stockin.CategoryId+" AND CompanyId = "+stockin.CompanyId+" ";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sd = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sd);
            conn.Close();
            return dt;
        }

        //Update Item
        public bool IsAdd(Stockin stockin)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"update Inventory set Quantity = (select Quantity from Inventory Where ItemId = (Select Id from Items where name = '" + stockin.Item + "') ) + "+stockin.SIQuantity+" Where ItemId = (Select Id from Items where name = '" + stockin.Item + "')";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            bool isRowAffected = command.ExecuteNonQuery() > 0;
            conn.Close();
            return isRowAffected;
        }

    }
}
