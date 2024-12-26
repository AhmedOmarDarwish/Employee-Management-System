namespace Employee_Management_System
{
    public partial class MainForm : Form
    {


        public MainForm(string userName)
        {
            InitializeComponent();
            AddLayoutViews();
            InitTimer();
            Current_User.Text = $"Welcome {userName}";
        }

        private void AddLayoutViews()
        {
            dashboard1 = new Dashboard();
            addEmployee1 = new AddEmployee();
            salary1 = new Salary();
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(addEmployee1);
            panel3.Controls.Add(salary1);
        }

        private void InitTimer()
        {
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Tick += (obj, eventArgs) =>
            {
                Date_Time.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
            };
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }
        private void AddEmployee_Btn_Click(object sender, EventArgs e)
        {
            addEmployee1.Refresh();
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;
        }

        private void Salary_Btn_Click(object sender, EventArgs e)
        {
            salary1.Refresh();

            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;
        }

        private void Dashboard_Btn_Click_1(object sender, EventArgs e)
        {
            
            dashboard1.Refresh();

            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;

        }
    }
}
