using Employee_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class AddEmployee : UserControl
    {
        EmployeeCRUD employeeCRUD  = new EmployeeCRUD();
        public AddEmployee()
        {
            InitializeComponent();
            displayEmployeeData();
        }
        public void displayEmployeeData()
        {
            //EmployeeData employeeData = new EmployeeData();
            //List<EmployeeData> employeeDatas = employeeData.employeesListData();
            dataGridView1.DataSource = employeeCRUD.GetAll();
        }

        
    }
}
