using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class StockOutVM
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string CompanyName { get; set; }
        //public string CategoryName { get; set; }
        public string StockOutQuantity { get; set; }
    }
}
