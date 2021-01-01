using Sales_and_Inventory_Management_System.Data_Access_Layer;
using Sales_and_Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Business_Logic_Layer
{
    class CustomerService
    {
        CustomerDataAccess customerDataAccess;
        public CustomerService()
        {
            this.customerDataAccess = new CustomerDataAccess();
        }
        public List<Customer> GetListOfCustomer()
        {
            return this.customerDataAccess.GetAllCustomer();
        }
        public int AddNewCustomer (string customerName, string phoneNo)
        {
            Customer customer = new Customer()
            {
                CustomerName = customerName,
                PhoneNo = Convert.ToInt32(phoneNo)
            };
            return this.customerDataAccess.InsertCustomer(customer);
        }
        public List<Customer> GetCustomerListForSearch(string customerName)
        {
            return customerDataAccess.GetCustomerForSearch(customerName);
        }
    }
}
