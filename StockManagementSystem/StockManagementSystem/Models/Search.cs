using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Search
    {
        public int CompanyId { get; set; }
        public int CategoryId { get; set; }
        public string Company { get; set; }
        public string Category { get; set; }
    }
}
