using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;
using StockManagementSystem.DAL;

namespace StockManagementSystem.BLL
{
    public class LoginManager
    {
        public bool IsVerified(Login login)
        {
            if (string.IsNullOrEmpty(login.Name) || string.IsNullOrEmpty(login.Password))
            {
                return true;
            }

            return false;
        }

        public bool IsSuccess(Login login)
        {
            LoginRepository loginRepository = new LoginRepository();
            bool isLogin = loginRepository.IsSuccessLog(login);
            return isLogin;
        }


    }
}
