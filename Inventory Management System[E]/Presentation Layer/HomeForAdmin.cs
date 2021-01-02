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
    public partial class HomeForAdmin : Form
    {
        int id = 0;
        string username;
        public HomeForAdmin(string username)
        {
            this.username = username;
            InitializeComponent();
            addUserButton.Click += this.RefreshGridView;
            updateUserButton.Click += this.RefreshGridView;
            updateUserButton.Click += this.ClearFields;
            deleteUserButton.Click += this.RefreshGridView;
            deleteUserButton.Click += this.ClearFields;
        }

        private void HomeForAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomeForAdmin_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            loadListOfUsersGridView.DataSource = userService.GetListOfUsers();
        }

        void RefreshGridView(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            loadListOfUsersGridView.DataSource = userService.GetListOfUsers();
        }

        void ClearFields(object sender, EventArgs e)
        {
            nameTextBox.Text = userNameTextBox.Text = passwordTextBox.Text=emailTextBox.Text=GenderComboBox.Text = string.Empty;

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || userNameTextBox.Text == "" || passwordTextBox.Text == "" || emailTextBox.Text == "" || GenderComboBox.Text == "")
            {
                MessageBox.Show("All boxes have to be filled");
            }
            else
            {
                UserService userService = new UserService();
                bool results = userService.UsernameValidation(userNameTextBox.Text);
                if (results)
                {
                    MessageBox.Show("This Username already exist");
                }
                else
                {
                    userService = new UserService();
                    int result = userService.AddNewUser(nameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text, emailTextBox.Text, dateOfBirthDateTimePicker.Text, GenderComboBox.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("User added successfully");
                        ClearFields(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Error adding user");
                    }
                }
            }
        }

        private void loadListOfUsersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)loadListOfUsersGridView.Rows[e.RowIndex].Cells[0].Value;
            nameTextBox.Text = loadListOfUsersGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            userNameTextBox.Text = loadListOfUsersGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            passwordTextBox.Text = loadListOfUsersGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            emailTextBox.Text = loadListOfUsersGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            UserService userService = new UserService();
            GenderComboBox.Text = userService.GetUserGender(id);
            userService = new UserService();
            dateOfBirthDateTimePicker.Text = userService.GetUserDateOfBirth(id);

        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            int result = userService.UpdateUser(id,nameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text,emailTextBox.Text,dateOfBirthDateTimePicker.Text,GenderComboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("User updated successfully");
            }
            else
            {
                MessageBox.Show("Error updating user");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            if (userService.GetUserType(userNameTextBox.Text) == "Admin")
            {
                MessageBox.Show("Can not delete Admin");
            }
            else
            {
                userService = new UserService();
                int result = userService.DeleteUser(id);
                if (result > 0)
                {
                    MessageBox.Show("User deleted successfully");
                }
                else
                {
                    MessageBox.Show("Error delating user");
                }
            }
            
        }

        private void CategoryManagementButton_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement(username);
            categoryManagement.Show();
            this.Hide();
        }

        private void ProductManagementButton_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement(username);
            productManagement.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
