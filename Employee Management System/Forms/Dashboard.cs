using Employee_Management_System.Models;

namespace Employee_Management_System
{
    public partial class Dashboard : UserControl
    {
        EmployeeCRUD employeeCRUD = new EmployeeCRUD();

        public Dashboard()
        {
            InitializeComponent();
            DisplayNumberOfEmp();



        }

        public void DisplayNumberOfEmp()
        {
            TEmployee.Text = employeeCRUD.CountEmployees().ToString();
            AEmployee.Text = employeeCRUD.CountActiveEmployees().ToString();
            InEmployee.Text = employeeCRUD.CountInctiveEmployees().ToString();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible && !Disposing)
            {
                DisplayNumberOfEmp();
            }
        }

    }
}
