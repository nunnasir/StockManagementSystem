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
    public class CompanyRepository
    {
        Connection connection = new Connection();

        //Save Companny
        public bool IsAdd(Companny companny)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string insertQuery = @"INSERT INTO Company VALUES('" + companny.Name + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
            conn.Open();
            bool isRowAffected = insertCommand.ExecuteNonQuery() > 0;
            conn.Close();
            return isRowAffected;
        }

        //Update Category
        public bool IsUpdate(Companny companny)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string updateQuery = @"UPDATE Company SET Name = '" + companny.Name + "' Where Id = (SELECT Id FROM Company Where Name = '" + companny.OldName + "')";
            SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
            conn.Open();
            bool isRowAffected = updateCommand.ExecuteNonQuery() > 0;
            conn.Close();
            return isRowAffected;
        }

        //Load Category on Gridview
        public DataTable AddCompany()
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string selectQuery = @"SELECT Name FROM Company ORDER BY Id DESC";
            SqlCommand selectCommand = new SqlCommand(selectQuery, conn);
            conn.Open();
            SqlDataReader sd = selectCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sd);
            conn.Close();
            return dt;
        }

        //Check Existing Item
        public bool IsExist(Companny companny)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"SELECT * FROM Company WHERE Name = '" + companny.Name + "' ";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            bool dataExisted = dr.Read();
            conn.Close();
            return dataExisted;
        }
    }
}
