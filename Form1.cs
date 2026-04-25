namespace WinFormsApp1
{
    public partial class Form1 : Form

    {
        private string username = "D'metabolite";
        private string password = "Akorede";
        public Form1()
        {
            InitializeComponent();
        }
        public bool Isvalid()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("This field can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("This field can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (!Isvalid()) 
            {
                if (txtPassword.Text.Length < 5)
                {
                    MessageBox.Show("The password length is too short. The password should be atleast 6 character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (username == txtUsername.Text && password == txtPassword.Text) 
                {
                 MessageBox.Show("Login Successful","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credetials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
