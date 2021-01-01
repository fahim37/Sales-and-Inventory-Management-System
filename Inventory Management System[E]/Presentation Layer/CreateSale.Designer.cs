
namespace Inventory_Management_System_E_.Presentation_Layer
{
    partial class CreateSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.saleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalOrderedAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lastOrderedLebel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.orderCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RemoveTextBox = new System.Windows.Forms.TextBox();
            this.removeProductbutton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.addNewCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerSearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(0, 69);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(602, 311);
            this.productsDataGridView.TabIndex = 2;
            this.productsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellClick);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(398, 22);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(180, 24);
            this.categoryComboBox.TabIndex = 4;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(134, 90);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(191, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AllowUserToDeleteRows = false;
            this.salesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Location = new System.Drawing.Point(410, 465);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.ReadOnly = true;
            this.salesDataGridView.Size = new System.Drawing.Size(857, 301);
            this.salesDataGridView.TabIndex = 10;
            this.salesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellClick);
            // 
            // saleDateTimePicker
            // 
            this.saleDateTimePicker.Location = new System.Drawing.Point(134, 128);
            this.saleDateTimePicker.Name = "saleDateTimePicker";
            this.saleDateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.saleDateTimePicker.TabIndex = 13;
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.placeOrderButton.Location = new System.Drawing.Point(134, 163);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(191, 47);
            this.placeOrderButton.TabIndex = 14;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Quantity.Location = new System.Drawing.Point(10, 91);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(64, 16);
            this.Quantity.TabIndex = 15;
            this.Quantity.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(10, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sales Date";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(134, 19);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.customerNameTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(10, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Customer Name";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(134, 54);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.productNameTextBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Product Name";
            // 
            // totalOrderedAmount
            // 
            this.totalOrderedAmount.AutoSize = true;
            this.totalOrderedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrderedAmount.Location = new System.Drawing.Point(519, 247);
            this.totalOrderedAmount.Name = "totalOrderedAmount";
            this.totalOrderedAmount.Size = new System.Drawing.Size(0, 16);
            this.totalOrderedAmount.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(638, 795);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Last Ordered :";
            // 
            // lastOrderedLebel
            // 
            this.lastOrderedLebel.AutoSize = true;
            this.lastOrderedLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastOrderedLebel.Location = new System.Drawing.Point(750, 794);
            this.lastOrderedLebel.Name = "lastOrderedLebel";
            this.lastOrderedLebel.Size = new System.Drawing.Size(0, 20);
            this.lastOrderedLebel.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Order count :";
            // 
            // orderCount
            // 
            this.orderCount.AutoSize = true;
            this.orderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCount.Location = new System.Drawing.Point(503, 198);
            this.orderCount.Name = "orderCount";
            this.orderCount.Size = new System.Drawing.Size(0, 16);
            this.orderCount.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(5, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Remove Product";
            // 
            // RemoveTextBox
            // 
            this.RemoveTextBox.Location = new System.Drawing.Point(134, 18);
            this.RemoveTextBox.Name = "RemoveTextBox";
            this.RemoveTextBox.Size = new System.Drawing.Size(191, 20);
            this.RemoveTextBox.TabIndex = 27;
            // 
            // removeProductbutton
            // 
            this.removeProductbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProductbutton.ForeColor = System.Drawing.Color.Red;
            this.removeProductbutton.Location = new System.Drawing.Point(134, 56);
            this.removeProductbutton.Name = "removeProductbutton";
            this.removeProductbutton.Size = new System.Drawing.Size(191, 47);
            this.removeProductbutton.TabIndex = 29;
            this.removeProductbutton.Text = "Remove";
            this.removeProductbutton.UseVisualStyleBackColor = true;
            this.removeProductbutton.Click += new System.EventHandler(this.removeProductbutton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(89, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(180, 22);
            this.searchTextBox.TabIndex = 30;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Search ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(303, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Categories ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(407, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Orders";
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Location = new System.Drawing.Point(0, 69);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.Size = new System.Drawing.Size(401, 311);
            this.customersDataGridView.TabIndex = 0;
            this.customersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDataGridView_CellClick);
            // 
            // addNewCustomer
            // 
            this.addNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCustomer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addNewCustomer.Location = new System.Drawing.Point(407, 89);
            this.addNewCustomer.Name = "addNewCustomer";
            this.addNewCustomer.Size = new System.Drawing.Size(215, 39);
            this.addNewCustomer.TabIndex = 34;
            this.addNewCustomer.Text = "Add Customer";
            this.addNewCustomer.UseVisualStyleBackColor = true;
            this.addNewCustomer.Click += new System.EventHandler(this.addNewCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customerSearchTextBox);
            this.groupBox1.Controls.Add(this.addNewCustomer);
            this.groupBox1.Controls.Add(this.customersDataGridView);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.totalOrderedAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.orderCount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 380);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Search ";
            // 
            // customerSearchTextBox
            // 
            this.customerSearchTextBox.Location = new System.Drawing.Point(146, 24);
            this.customerSearchTextBox.Name = "customerSearchTextBox";
            this.customerSearchTextBox.Size = new System.Drawing.Size(180, 22);
            this.customerSearchTextBox.TabIndex = 35;
            this.customerSearchTextBox.TextChanged += new System.EventHandler(this.customerSearchTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.productNameTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.customerNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Quantity);
            this.groupBox2.Controls.Add(this.placeOrderButton);
            this.groupBox2.Controls.Add(this.saleDateTimePicker);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 230);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Place Order";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeProductbutton);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.RemoveTextBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 708);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 118);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remove Order";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.searchTextBox);
            this.groupBox4.Controls.Add(this.categoryComboBox);
            this.groupBox4.Controls.Add(this.productsDataGridView);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(665, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(602, 380);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products";
            // 
            // CreateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 856);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lastOrderedLebel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salesDataGridView);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "CreateSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateSale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateSale_FormClosing);
            this.Load += new System.EventHandler(this.CreateSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.DateTimePicker saleDateTimePicker;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalOrderedAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lastOrderedLebel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label orderCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RemoveTextBox;
        private System.Windows.Forms.Button removeProductbutton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Button addNewCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerSearchTextBox;
    }
}