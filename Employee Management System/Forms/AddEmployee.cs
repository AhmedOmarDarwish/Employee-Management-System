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
        public AddEmployee()
        {
            InitializeComponent();
            displayEmployeeData();
        }
        public void displayEmployeeData()
        {
            // EmployeeData employeeData = new EmployeeData();
            // List<EmployeeData> employeeDatas = employeeData.employeesListData();
            //dataGridView1.DataSource = employeeDatas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Stuts_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
