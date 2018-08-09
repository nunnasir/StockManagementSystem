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
    public class DateSearchRepository
    {
        Connection connection = new Connection();

        //Load Date search Item on Grid vie
        public DataTable LoadDateSearchItem(DateSearch dateSearch)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            //string query = @"SELECT ite.Name ItemName, sto.Quantity Quantity FROM StockOut sto INNER JOIN Items ite ON sto.ItemId = ite.Id WHERE Date BETWEEN '" + dateSearch.FromDate + "' AND '" + dateSearch.ToDate + "' AND MediumId = 1 ORDER BY sto.Id DESC";
            string query = @"SELECT Name ItemName, SUM(Quantity) Quantity from StockoutDetail WHERE Date Between '" + Utility.Utility.GetSqlDateOnly(dateSearch.FromDate) + "' AND '" + Utility.Utility.GetSqlDateOnly(dateSearch.ToDate) + "' group by Name, Medium Having  Medium = 'Sell' ORDER BY Quantity DESC";
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
