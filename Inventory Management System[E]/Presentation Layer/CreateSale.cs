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
        public CreateSale()
        {
            InitializeComponent();
        }

        private void CreateSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
