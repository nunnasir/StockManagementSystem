using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;

namespace StockManagementSystem.DAL
{
    public class CategoryRepository
    {
        Connection connection = new Connection();
        
        //Save Category
        public bool IsAdd(Category category)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string insertQuery = @"INSERT INTO Category VALUES('"+category.Name+"')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
            conn.Open();
            bool isRowAffected = insertCommand.ExecuteNonQuery() > 0;
            conn.Close();
            return isRowAffected;
        }

        //Update Category
        public bool IsUpdate(Category category)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string updateQuery = @"UPDATE Category SET Name = '"+category.Name+"' Where Id = (SELECT Id FROM Category Where Name = '"+category.OldName+"')";
            SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
            conn.Open();
            bool isRowAffected = updateCommand.ExecuteNonQuery() > 0;
            conn.Close();
            return isRowAffected;
        }

        //Load Category on Gridview
        public DataTable AddCategory()
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string selectQuery = @"SELECT Name FROM Category ORDER BY Id DESC";
            SqlCommand selectCommand = new SqlCommand(selectQuery, conn);
            conn.Open();
            SqlDataReader sd = selectCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sd);
            conn.Close();
            return dt;
        }

        //Check Existing Item
        public bool IsExist(Category category)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"SELECT * FROM Category WHERE Name = '"+category.Name+"' ";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            bool dataExisted = dr.Read();
            conn.Close();
            return dataExisted;
        }

    }
}
