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
    public partial class Dashboard : UserControl
    {
        EmployeeCRUD employeeCRUD = new EmployeeCRUD();
       
        public Dashboard()
        {
            InitializeComponent();
            TEmployee.Text = employeeCRUD.CountEmployees().ToString();
            AEmployee.Text = employeeCRUD.CountActiveEmployees().ToString();
            InEmployee.Text = employeeCRUD.CountInctiveEmployees().ToString();
        }
    }
}
