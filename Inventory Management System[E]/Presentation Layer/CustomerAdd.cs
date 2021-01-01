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

namespace Sales_and_Inventory_Management_System.Presentation_Layer
{
    public partial class CustomerAdd : Form
    {
        public CustomerAdd()
        {
            InitializeComponent();
        }

        private void CustomerAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            int result = customerService.AddNewCustomer(customerNameTextBox.Text, phoneNoTextBox.Text);
            this.Hide();
            CreateSale createSale = new CreateSale();
            createSale.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateSale createSale = new CreateSale();
            createSale.Show();
        }
    }
}
