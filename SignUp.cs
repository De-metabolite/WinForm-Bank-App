using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SignUp : Form

    {
        
            
        public SignUp()
        {
            InitializeComponent();
        }

          

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
               {
                MessageBox.Show("All fields are required");
               }
               else if(cmbAccountType.SelectedIndex == -1) 
               {
                MessageBox.Show("Please, kindly select from the dropdown.");
               }
            else if(txtPassword.Text.Length < 6)
            {
                MessageBox.Show("The password is too short, we only accept atleast six characters.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool Isvalid = decimal.TryParse(txtAmount.Text, out decimal amount);
            if(Isvalid && amount >= 1050)
            {
                BankAccount account = new BankAccount(txtFullName.Text, amount, cmbAccountType.Text,txtUsername.Text,
                    txtPassword.Text);
                Customers.accounts.Add(account);
                MessageBox.Show("Account Created Successfully.Your Account Number is:" + account.AccountNumber);
            }
            else 
            {
                MessageBox.Show("Invalid Requirements.");
            }
        }
    }
}
