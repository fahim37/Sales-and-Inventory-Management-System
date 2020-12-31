using Sales_and_Inventory_Management_System.Entities;
using Sales_and_Inventory_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Data_Access_Layer
{
    class SaleDataAccess
    {
        DataAccess dataAccess;
        public SaleDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public int CreateSale(Sale sale)
        {
            string sql = "INSERT INTO SALES (CustomerName,CustomerId,ProductName,ProductId,SalesDate,Quantity,UnitPrice,TotalPrice) VALUES('" + sale.CustomerName + "'," + sale.CustomerId + ",'" + sale.ProductName + "'," + sale.ProductId + ",'" + sale.SalesDate + "'," + sale.Quantity + "," + sale.UnitPrice + ","+sale.TotalPrice+")";
            return this.dataAccess.ExecuteQuery(sql);
        }
        public List<Sale> GetAllSalesListByDate(string from, string to)
        {
            string sql = "SELECT * FROM Sales WHERE SalesDate BETWEEN '" + from + "' AND '" + to + "'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();
                sale.CustomerName = reader["CustomerName"].ToString();
                sale.CustomerId = (int)reader["CustomerId"];
                sale.ProductName = reader["ProductName"].ToString();
                sale.ProductId = (int)reader["ProductId"];
                sale.SalesDate = reader["SalesDate"].ToString();
                sale.Quantity = (int)reader["Quantity"];
                sale.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                sale.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                sales.Add(sale);
            }
            return sales;
        }
    }
}

