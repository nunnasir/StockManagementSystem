using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;
using StockManagementSystem.DAL;
using StockManagementSystem.UI.ItemSetup;

namespace StockManagementSystem.BLL
{
    public class ItemManagement
    {
        ItemRepository itemRepository = new ItemRepository();

        //Check Exist Data
        public bool IsExisted(Item item)
        {
            bool add = itemRepository.IsExist(item);
            return add;
        }

        //Verified Field
        public bool IsVerified(Item item)
        {
            if (string.IsNullOrEmpty(item.Name) || string.IsNullOrEmpty(item.Category) || string.IsNullOrEmpty(item.Company) || string.IsNullOrEmpty(item.Reorder))
            {
                return true;
            }

            return false;
        }


        //Check Error
        public bool IsError(Item item)
        {
            if (!(string.IsNullOrEmpty(item.ReorderError)))
            {
                return true;
            }

            return false;
        }

        //Save Category
        public bool IsAdded(Item item)
        {
            bool add = itemRepository.IsAdd(item);
            return add;
        }



    }
}
