using Inventory_Management_System_E_.Entities;
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
        public List<CustomerOrder> GetAllSalesListByCustomerId(int id)
        {
            return this.saleDataAccess.GetCustomerOrderById(id);
        }
        
        public int CreateSale(string customerName, int customerId, string productName, int productId, string salesDate, int quantity, double unitPrice, int availableQuantity)
        {
            int newQuantity = 0;
            double totalPrice = unitPrice * quantity;
            if (availableQuantity >= quantity)
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
                newQuantity = availableQuantity - quantity;
                ProductDataAccess productDataAccess = new ProductDataAccess();
                productDataAccess.UpdateQuantity(newQuantity, productId);
                saleDataAccess = new SaleDataAccess();
                return saleDataAccess.CreateSale(sale);
            }
            else return 0;
        }
        public int RemoveOrder(int orderId,int productId, int availableQuantity,int quantity)
        {
            int newQuantity = 0;
            newQuantity = availableQuantity + quantity;
            ProductDataAccess productDataAccess = new ProductDataAccess();
            productDataAccess.UpdateQuantity(newQuantity, productId);
            SaleDataAccess saleDataAccess = new SaleDataAccess();
            return saleDataAccess.RemoveOrder(orderId);
        }
        public string TotalOrderedAmount(int id)
        {
            SaleDataAccess saleDataAccess = new SaleDataAccess();
            return saleDataAccess.TotalAmount(id);
        }
        public string LastOrderedDate(int id)
        {
            SaleDataAccess saleDataAccess = new SaleDataAccess();
            return saleDataAccess.LastOrderedDate(id);
        }
        public string OrderCount(int id)
        {
            SaleDataAccess saleDataAccess = new SaleDataAccess();
            return saleDataAccess.OrderCount(id);
        }
    }
}
