using Sales_and_Inventory_Management_System.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System_E_.Presentation_Layer
{
    public partial class CreateSale : Form
    {
        string customerName;
        int customerId;
        string productName;
        int productId;
        double unitPrice;
        public CreateSale()
        {
            InitializeComponent();
        }

        private void CreateSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CustomersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerName = CustomersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            customerId = (int)CustomersDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productName = ProductsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            productId = (int)ProductsDataGridView.Rows[e.RowIndex].Cells[0].Value;
            unitPrice = Convert.ToDouble(ProductsDataGridView.Rows[e.RowIndex].Cells[2].Value);
        }
        private void CreateSale_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            CategoryComboBox.DataSource = categoryService.GetCategoryNameList();
            CustomerService customerService = new CustomerService();
            CustomersDataGridView.DataSource = customerService.GetListOfCustomer();

        }
        void RefreshGridview(object sender, EventArgs e)
        {

        }
        void ClearFields(object sender, EventArgs e)
        {

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();
            int result = saleService.CreateSale(customerName,customerId,productName,productId,SaleDateTimePicker.Value.ToString("MM/dd/yyyy"), Convert.ToInt32(QuantityTextBox.Text) ,unitPrice);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            ProductsDataGridView.DataSource = categoryService.GetProductListByCategory(CategoryComboBox.Text);
        }
    }
}
