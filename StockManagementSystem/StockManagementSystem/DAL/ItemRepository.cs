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
    public class ItemRepository
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

        //Check Existing Item
        public bool IsExist(Item item)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"SELECT * FROM Items WHERE Name = '" + item.Name + "' ";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            bool dataExisted = dr.Read();
            conn.Close();
            return dataExisted;
        }

        //Save Item
        public bool IsAdd(Item item)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string itemQuery = @"INSERT INTO Items VALUES('"+item.Name+"', (SELECT Id FROM Category WHERE Name = '"+item.Category+"'), (SELECT Id FROM Company WHERE Name = '"+item.Company+"'))";
            string inventQuery = @"INSERT INTO Inventory VALUES((SELECT Id From Items WHERE Name = '"+item.Name+"'), "+item.quantity+", "+item.Reorder+")";
            SqlCommand itemCommand = new SqlCommand(itemQuery, conn);
            SqlCommand inventCommand = new SqlCommand(inventQuery,conn);
            conn.Open();
            bool isRowAffected = itemCommand.ExecuteNonQuery() > 0 && inventCommand.ExecuteNonQuery() > 0;
            conn.Close();
            return isRowAffected;
        }
       
    }
}
