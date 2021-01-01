﻿using Sales_and_Inventory_Management_System.Data_Access_Layer;
using Sales_and_Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Business_Logic_Layer
{
    class ProductService
    {
        ProductDataAccess productDataAcess;
        public ProductService()
        {
            productDataAcess = new ProductDataAccess();
        }

        public List<Product> GetProductList()
        {
            return productDataAcess.GetAllProducts();
        }
        public int AddNewProduct(string productName,string price,string quantity,string categoryName)
        {
            int categoryId = productDataAcess.GetCategoryId(categoryName);
            Product product = new Product()
            {
                ProductName=productName,
                Price=Convert.ToDouble(price),
                Quantity=Convert.ToInt32(quantity),
                CategoryId=categoryId
            };
            productDataAcess = new ProductDataAccess();
            return productDataAcess.InsertProduct(product);
        }
        public List<Product> GetProductListForSearch(string productName)
        {
            return productDataAcess.GetProductsForSearch(productName);
        }
        public int GetProductQuantity(int productId)
        {
            return productDataAcess.GetProductQuantity(productId);
        }
    }
}
