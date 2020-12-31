using Sales_and_Inventory_Management_System.Data_Access_Layer;
using Sales_and_Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Business_Logic_Layer
{
    class SaleService
    {
        SaleDataAccess saleDataAccess;
        public SaleService()
        {
            this.saleDataAccess = new SaleDataAccess();
        }
        public List<Sale> GetAllSalesListByDate(string from, string to)
        {
            return this.saleDataAccess.GetAllSalesListByDate(from, to);
        }

        public int CreateSale(string customerName, int customerId, string productName, int productId, string salesDate, int quantity, double unitPrice)
        {
            int quan = 0;
            double totalPrice = unitPrice * quantity;
            ProductDataAccess productDataAccess = new ProductDataAccess();
            quan = productDataAccess.GetProductQuantity(productId);
            if (quan >= quantity)
            {
                Sale sale = new Sale()
                {
                    CustomerName = customerName,
                    CustomerId = customerId,
                    ProductName = productName,
                    ProductId = productId,
                    SalesDate = salesDate,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    TotalPrice = totalPrice
                };
                //int newQuantity = quan - quantity;
                //productDataAccess.UpdateQuantity(newQuantity, productId);
                saleDataAccess = new SaleDataAccess();
                return saleDataAccess.CreateSale(sale);
            }
            else return 0;
        }
    }
}
