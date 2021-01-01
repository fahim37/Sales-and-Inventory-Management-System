
namespace Sales_and_Inventory_Management_System.Presentation_Layer
{
    partial class CustomerManagement
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
            this.CustomerLoadDataGridView = new System.Windows.Forms.DataGridView();
            this.customerSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLoadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLoadDataGridView
            // 
            this.CustomerLoadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerLoadDataGridView.Location = new System.Drawing.Point(33, 76);
            this.CustomerLoadDataGridView.Name = "CustomerLoadDataGridView";
            this.CustomerLoadDataGridView.Size = new System.Drawing.Size(550, 394);
            this.CustomerLoadDataGridView.TabIndex = 0;
            // 
            // customerSearchTextBox
            // 
            this.customerSearchTextBox.Location = new System.Drawing.Point(224, 37);
            this.customerSearchTextBox.Name = "customerSearchTextBox";
            this.customerSearchTextBox.Size = new System.Drawing.Size(174, 20);
            this.customerSearchTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 781);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerSearchTextBox);
            this.Controls.Add(this.CustomerLoadDataGridView);
            this.Name = "CustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerManagement_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLoadDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerLoadDataGridView;
        private System.Windows.Forms.TextBox customerSearchTextBox;
        private System.Windows.Forms.Label label1;
    }
}