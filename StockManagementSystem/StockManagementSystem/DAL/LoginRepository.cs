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
    public class LoginRepository
    {
        Connection connection = new Connection();

        public bool IsSuccessLog(Login login)
        {
            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"SELECT count(*) count FROM Login WHERE Name = '"+login.Name+"' and Password = '"+login.Password+"' ";
            SqlCommand command = new SqlCommand(query,conn);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            bool isRowFind = dt.Rows[0][0].ToString() == "1";
            conn.Close();
            return isRowFind;
        }
    }
}
