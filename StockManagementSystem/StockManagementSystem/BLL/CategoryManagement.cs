using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DAL;
using StockManagementSystem.Models;

namespace StockManagementSystem.BLL
{
    public class CategoryManagement
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        //Verified Field
        public bool IsVerified(Category category)
        {
            if (string.IsNullOrEmpty(category.Name))
            {
                return true;
            }

            return false;
        }

        //Check Error
        public bool IsError(Category category)
        {
            if (!(string.IsNullOrEmpty(category.ErrorText)))
            {
                return true;
            }

            return false;
        }


        //Save Category
        public bool IsAdded(Category category)
        {
            bool add = categoryRepository.IsAdd(category);
            return add;
        }

        //Update Category
        public bool IsUpdated(Category category)
        {
            bool add = categoryRepository.IsUpdate(category);
            return add;
        }

        //Check Exist Data
        public bool IsExisted(Category category)
        {
            bool add = categoryRepository.IsExist(category);
            return add;
        }

    }
}
