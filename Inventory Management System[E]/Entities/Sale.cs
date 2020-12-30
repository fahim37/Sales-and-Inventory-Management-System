using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_E_.Entities
{
    class Sale
    {
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public string SalesDate { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
