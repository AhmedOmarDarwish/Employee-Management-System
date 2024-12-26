﻿using Employee_Management_System.Models;
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
    public partial class Salary : UserControl
    {
        EmployeeCRUD employeeCRUD;
        public Salary()
        {
            employeeCRUD = new EmployeeCRUD();
            InitializeComponent();
            DisplayEmployeeData();
        }

        public void DisplayEmployeeData()
        {
            EmpGridView.DataSource = employeeCRUD.GetAll();
        }


        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void EmpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = EmpGridView.Rows[e.RowIndex];
                empIdTB.Text = row.Cells[1].Value.ToString();
                empNameTB.Text = row.Cells[2].Value.ToString();
                empSalaryUN.Value = Convert.ToDecimal(row.Cells[7].Value);

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (empIdTB.Text == ""
               || empNameTB.Text == ""
               || empSalaryUN.Value ==0)
            {
                MessageBox.Show(
                  "Please select the employee whose salary you want to update.",
                  "Selection Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {

                try
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Update salary for this Employee?",
                     "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (check == DialogResult.Yes)
                    {
                        employeeCRUD.UpdateSalary(new Employee()
                        {
                            EmployeeId = empIdTB.Text.Trim(),
                            FullName = empNameTB.Text.Trim(),
                            Salary = (double)empSalaryUN.Value,
                            DateOfUpdate = DateTime.Now,
                        });

                        MessageBox.Show(
                        "The employee has been Updated to the database :)",
                         "Update Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearFields();
                        DisplayEmployeeData();

                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void ClearFields()
        {
            empIdTB.Clear();
            empNameTB.Clear();
            empSalaryUN.Value = 0;
        }
    }
}
