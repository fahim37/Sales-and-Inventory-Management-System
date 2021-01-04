namespace Sales_and_Inventory_Management_System.Presentation_Layer
{
    partial class HomeForUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerManagementButton = new System.Windows.Forms.Button();
            this.orderManagementButton = new System.Windows.Forms.Button();
            this.productManagementButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeNameLinkLabel = new System.Windows.Forms.LinkLabel();
            this.logOutButton1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerManagementButton);
            this.groupBox1.Controls.Add(this.orderManagementButton);
            this.groupBox1.Controls.Add(this.productManagementButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 467);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Panel";
            // 
            // customerManagementButton
            // 
            this.customerManagementButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerManagementButton.Location = new System.Drawing.Point(607, 168);
            this.customerManagementButton.Name = "customerManagementButton";
            this.customerManagementButton.Size = new System.Drawing.Size(235, 92);
            this.customerManagementButton.TabIndex = 12;
            this.customerManagementButton.Text = "Customer Management";
            this.customerManagementButton.UseVisualStyleBackColor = true;
            this.customerManagementButton.Click += new System.EventHandler(this.customerManagementButton_Click);
            // 
            // orderManagementButton
            // 
            this.orderManagementButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderManagementButton.Location = new System.Drawing.Point(336, 168);
            this.orderManagementButton.Name = "orderManagementButton";
            this.orderManagementButton.Size = new System.Drawing.Size(230, 92);
            this.orderManagementButton.TabIndex = 11;
            this.orderManagementButton.Text = "Order Management";
            this.orderManagementButton.UseVisualStyleBackColor = true;
            this.orderManagementButton.Click += new System.EventHandler(this.orderManagementButton_Click);
            // 
            // productManagementButton
            // 
            this.productManagementButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productManagementButton.Location = new System.Drawing.Point(70, 168);
            this.productManagementButton.Name = "productManagementButton";
            this.productManagementButton.Size = new System.Drawing.Size(226, 92);
            this.productManagementButton.TabIndex = 10;
            this.productManagementButton.Text = "Product Management";
            this.productManagementButton.UseVisualStyleBackColor = true;
            this.productManagementButton.Click += new System.EventHandler(this.productManagementButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(749, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee,";
            // 
            // EmployeeNameLinkLabel
            // 
            this.EmployeeNameLinkLabel.AutoSize = true;
            this.EmployeeNameLinkLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLinkLabel.Location = new System.Drawing.Point(826, 36);
            this.EmployeeNameLinkLabel.Name = "EmployeeNameLinkLabel";
            this.EmployeeNameLinkLabel.Size = new System.Drawing.Size(51, 19);
            this.EmployeeNameLinkLabel.TabIndex = 5;
            this.EmployeeNameLinkLabel.TabStop = true;
            this.EmployeeNameLinkLabel.Text = "Name";
            this.EmployeeNameLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmployeeNameLinkLabel_LinkClicked);
            // 
            // logOutButton1
            // 
            this.logOutButton1.FlatAppearance.BorderSize = 0;
            this.logOutButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton1.ForeColor = System.Drawing.Color.Red;
            this.logOutButton1.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton1.Image")));
            this.logOutButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton1.Location = new System.Drawing.Point(946, 19);
            this.logOutButton1.Name = "logOutButton1";
            this.logOutButton1.Size = new System.Drawing.Size(112, 36);
            this.logOutButton1.TabIndex = 6;
            this.logOutButton1.Text = "Log Out";
            this.logOutButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutButton1.UseVisualStyleBackColor = true;
            this.logOutButton1.Click += new System.EventHandler(this.logOutButton1_Click);
            // 
            // HomeForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 640);
            this.Controls.Add(this.logOutButton1);
            this.Controls.Add(this.EmployeeNameLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomeForUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForUser_FormClosing);
            this.Load += new System.EventHandler(this.HomeForUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel EmployeeNameLinkLabel;
        private System.Windows.Forms.Button customerManagementButton;
        private System.Windows.Forms.Button orderManagementButton;
        private System.Windows.Forms.Button productManagementButton;
        private System.Windows.Forms.Button logOutButton1;
    }
}