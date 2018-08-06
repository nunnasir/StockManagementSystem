using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string ReorderError { get; set; }
        public string Reorder { get; set; }
        public string ErrorText { get; set; }
        public int quantity = 0;
    }
}
