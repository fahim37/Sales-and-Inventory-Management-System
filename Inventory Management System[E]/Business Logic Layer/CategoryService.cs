using Sales_and_Inventory_Management_System.Data_Access_Layer;
using Sales_and_Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Business_Logic_Layer
{
    class CategoryService
    {
        CategoryDataAccess categoryDataAccess;
        public CategoryService()
        {
            this.categoryDataAccess = new CategoryDataAccess();
        }

        public List<Category> GetListOfCategories()
        {
            return this.categoryDataAccess.GetAllCategories();
        }

        public int AddNewCategory(string categoryName)
        {
            Category category = new Category()
            {
                CategoryName=categoryName
            };
            return this.categoryDataAccess.InsertCategory(category);
        }
        public int UpdateCategory(int categoryId,string categoryName)
        {
            Category category = new Category()
            {
                CategoryId=categoryId,
                CategoryName = categoryName
            };
            return this.categoryDataAccess.UpdateCategory(category);
        }
        public int DeleteCategory(string categoryId)
        {
            return this.categoryDataAccess.DeleteCategory(Convert.ToInt32(categoryId));
        }
        public List<string> GetCategoryNameList()
        {
            return this.categoryDataAccess.GetCategoryNames();
        }
        public List<Product> GetProductListByCategory(string categoryName)
        {
            return this.categoryDataAccess.GetProductByCategory(categoryName);
        }
    }
}
