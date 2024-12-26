using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Employee_Management_System.Models;




namespace Employee_Management_System
{
    public partial class Register : Form
    {
        UserCRUD userCRUD = new UserCRUD();
        public Register()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            //Open Login Form
            Login loginForm = new Login();
            loginForm.Show();
            //Hide Me
            this.Hide();

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            Register_Password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            Register_Confirm_Password.PasswordChar = register_showPass.Checked ? '\0' : '*';


        }

        private void signup_Btn_Click(object sender, EventArgs e)
        {
            if (Register_username.Text == "" || Register_Password.Text == "" || Register_Confirm_Password.Text == "")
            {
                MessageBox.Show(
                    "Please Fill all Blank Fields",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (Register_Password.Text != Register_Confirm_Password.Text)
            {
                MessageBox.Show(
                    "Please Make Sure your Password Match",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                string userName = Register_username.Text.Trim();
                string userPassword = Register_Confirm_Password.Text;
                User user = userCRUD.GetEntityByuserName(userName);

                if (user != null)
                {
                    MessageBox.Show(
                     $"UserName {userName} is already taken :(",
                    "Information Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        userCRUD.Insert(new User(userName, userPassword, today));
                        MessageBox.Show(
                        "Registered Successfully :)",
                        "Success!",
                        MessageBoxButtons.OK,
                         MessageBoxIcon.Information);

                        Register_Password.Clear();
                        Register_username.Clear();
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
