using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Utility
{
    public class Utility
    {
        public static string GetSqlDateOnly(DateTime dateTime)
        {
            var day = dateTime.Day;
            var monnth = dateTime.Month;
            var year = dateTime.Year;

            return year + "-" + monnth + "-" + day;
        }
    }
}
