using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DAL;
using StockManagementSystem.Models;

namespace StockManagementSystem.BLL
{
    public class CompanyManagement
    {
        CompanyRepository companyRepository = new CompanyRepository();

        //Verified Field
        public bool IsVerified(Companny companny)
        {
            if (string.IsNullOrEmpty(companny.Name))
            {
                return true;
            }

            return false;
        }

        //Check Error
        public bool IsError(Companny companny)
        {
            if (!(string.IsNullOrEmpty(companny.ErrorText)))
            {
                return true;
            }

            return false;
        }

        //Save Companny
        public bool IsAdded(Companny companny)
        {
            bool add = companyRepository.IsAdd(companny);
            return add;
        }

        //Update Companny
        public bool IsUpdated(Companny companny)
        {
            bool add = companyRepository.IsUpdate(companny);
            return add;
        }

        //Check Exist Data
        public bool IsExisted(Companny companny)
        {
            bool add = companyRepository.IsExist(companny);
            return add;
        }

    }
}
