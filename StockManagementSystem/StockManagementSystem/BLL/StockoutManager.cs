using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;
using StockManagementSystem.DAL;

namespace StockManagementSystem.BLL
{
    public class StockoutManager
    {
        StockOutRepository stockoutRepository = new StockOutRepository();

        public bool SalesAdd(StockOut stockOut)
        {
            bool isAdded = stockoutRepository.SalesAdd(stockOut);
            return isAdded;
        }
    }
}
