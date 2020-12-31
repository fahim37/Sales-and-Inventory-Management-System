
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
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.SaleGridView = new System.Windows.Forms.DataGridView();
            this.SaleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.AllowUserToAddRows = false;
            this.CustomersDataGridView.AllowUserToDeleteRows = false;
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(12, 64);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.ReadOnly = true;
            this.CustomersDataGridView.Size = new System.Drawing.Size(387, 290);
            this.CustomersDataGridView.TabIndex = 0;
            this.CustomersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AllowUserToDeleteRows = false;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(576, 64);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.Size = new System.Drawing.Size(666, 290);
            this.ProductsDataGridView.TabIndex = 2;
            this.ProductsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Products";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(874, 19);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(214, 21);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(130, 435);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(142, 20);
            this.QuantityTextBox.TabIndex = 9;
            // 
            // SaleGridView
            // 
            this.SaleGridView.AllowUserToAddRows = false;
            this.SaleGridView.AllowUserToDeleteRows = false;
            this.SaleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleGridView.Location = new System.Drawing.Point(428, 415);
            this.SaleGridView.Name = "SaleGridView";
            this.SaleGridView.ReadOnly = true;
            this.SaleGridView.Size = new System.Drawing.Size(819, 301);
            this.SaleGridView.TabIndex = 10;
            // 
            // SaleDateTimePicker
            // 
            this.SaleDateTimePicker.Location = new System.Drawing.Point(130, 477);
            this.SaleDateTimePicker.Name = "SaleDateTimePicker";
            this.SaleDateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.SaleDateTimePicker.TabIndex = 13;
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Location = new System.Drawing.Point(130, 526);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(95, 47);
            this.PlaceOrderButton.TabIndex = 14;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(55, 438);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 15;
            this.Quantity.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sales Date";
            // 
            // CreateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 801);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(this.SaleDateTimePicker);
            this.Controls.Add(this.SaleGridView);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomersDataGridView);
            this.Name = "CreateSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateSale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateSale_FormClosing);
            this.Load += new System.EventHandler(this.CreateSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.DataGridView SaleGridView;
        private System.Windows.Forms.DateTimePicker SaleDateTimePicker;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label3;
    }
}