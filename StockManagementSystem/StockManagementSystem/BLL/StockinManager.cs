using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;
using StockManagementSystem.DAL;

namespace StockManagementSystem.BLL
{
    public class StockinManager
    {
        StockinRepository stockinRepository = new StockinRepository();

        //Verified Field
        public bool IsVerified(Stockin stockin)
        {
            if (string.IsNullOrEmpty(stockin.Item) || string.IsNullOrEmpty(stockin.Category) || string.IsNullOrEmpty(stockin.Company) || string.IsNullOrEmpty(stockin.SIQuantity.ToString()))
            {
                return true;
            }

            return false;
        }

        //Check Error
        public bool IsError(Stockin stockin)
        {
            if (!(string.IsNullOrEmpty(stockin.ErrorText)))
            {
                return true;
            }

            return false;
        }

        //Save Category
        public bool IsAdded(Stockin stockin)
        {
            bool add = stockinRepository.IsAdd(stockin);
            return add;
        }
    }
}
