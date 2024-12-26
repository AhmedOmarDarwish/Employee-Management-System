using Employee_Management_System.Models;
using System.Data;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class Login : Form
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\DEPI\C#\Pro\Employee Management System\Employee.mdf"";Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            //Open Register Form
            Register registerForm = new Register();
            registerForm.Show();
            //Hide Me
            this.Hide();


        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            UserCRUD userCRUD = new UserCRUD();

            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show(
                    "Please Fill all Blank Fields",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    User user = userCRUD.GetEntity(login_username.Text.Trim(), login_password.Text);
                    if (user != null)
                    {
                        MessageBox.Show(
                            $"Welcome {login_username.Text} Login Successfully :)",
                            "Information Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        MainForm mainForm = new MainForm(login_username.Text);
                        mainForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show(
                            "Incorrect User Name OR Password",
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

    }
}
