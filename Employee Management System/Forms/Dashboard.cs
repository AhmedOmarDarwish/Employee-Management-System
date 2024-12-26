using Employee_Management_System.Models;

namespace Employee_Management_System
{
    public partial class Dashboard : UserControl
    {
        EmployeeCRUD _employeeCRUD = new EmployeeCRUD();

        public Dashboard(EmployeeCRUD employeeCRUD)
        {
            InitializeComponent();
            _employeeCRUD = employeeCRUD;
            DisplayNumberOfEmp();



        }

        public void DisplayNumberOfEmp()
        {
            TEmployee.Text = _employeeCRUD.CountEmployees().ToString();
            AEmployee.Text = _employeeCRUD.CountActiveEmployees().ToString();
            InEmployee.Text = _employeeCRUD.CountInctiveEmployees().ToString();
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
