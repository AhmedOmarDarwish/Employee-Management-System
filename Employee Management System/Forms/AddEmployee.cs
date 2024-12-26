using Employee_Management_System.Models;


namespace Employee_Management_System
{
    public partial class AddEmployee : UserControl
    {
        EmployeeCRUD employeeCRUD;

        public AddEmployee()
        {
            employeeCRUD = new EmployeeCRUD();
            InitializeComponent();
            DisplayEmployeeData();
            //startFieldsStatus();
            EmpPositionCBox();
            empPictureBox.ImageLocation = @"D:\DEPI\C#\Pro\Employee Management System\Employee Management System\Resources\account.png";
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if(Visible && !Disposing)
            {
                DisplayEmployeeData();
            }
        }

        public void DisplayEmployeeData()
        {
            EmpGridView.DataSource = employeeCRUD.GetAll();
        }
        private void EmpPositionCBox()
        {
            empPositionCBox.DataSource = Enum.GetValues(typeof(EmployeePosition));
        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            empIdTB.Clear();
            empNameTB.Clear();
            empPhoneTB.Clear();
            maleRBtn.Checked = true;
            femaleRBtn.Checked = false;
            activeRBtn.Checked = true;
            empPositionCBox.SelectedIndex = 0;
            empPictureBox.Image = empPictureBox.InitialImage;
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            if (empIdTB.Text == ""
               || empNameTB.Text == ""
               || empPhoneTB.Text == "")
            {
                MessageBox.Show(
                "Please ensure all required fields are filled before proceeding",
                "Error Message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else if (employeeCRUD.GetEmployeeByEmpID(empIdTB.Text.Trim()) != null)
            {

                MessageBox.Show("The Employee ID already exists in the system. You can update the employee's information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                try
                {
                    employeeCRUD.Insert(new Employee()
                    {
                        EmployeeId = empIdTB.Text.Trim(),
                        FullName = empNameTB.Text.Trim(),
                        Gender = maleRBtn.Checked ? "Male" : "Female",
                        ContactNumber = empPhoneTB.Text.Trim(),
                        Position = (EmployeePosition)empPositionCBox.SelectedValue,
                        Image = empPictureBox.ImageLocation.ToString(),
                        Status = activeRBtn.Checked ? "Active" : "Inactive",
                        DateOfInsert = DateTime.Now,
                    });
                    MessageBox.Show(
                    "The employee has been added to the database :)",
                    "Success!",
                    MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                    ClearFields();
                    DisplayEmployeeData();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
        private void Update_Btn_Click(object sender, EventArgs e)
        {
            if (empIdTB.Text == ""
               || empNameTB.Text == ""
               || empPhoneTB.Text == "")
            {
                MessageBox.Show(
                "Please ensure all required fields are filled before Update",
                "Data Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else if (employeeCRUD.GetEmployeeByEmpID(empIdTB.Text.Trim()) == null)
            {

                MessageBox.Show($"The Employee ID '{empIdTB.Text.Trim()}' does not exist in the system. Please insert the employee's information to add them to the system.",
                                "Employee Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Update this Employee?",
                     "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (check == DialogResult.Yes)
                    {
                        employeeCRUD.Update(new Employee()
                        {
                            EmployeeId = empIdTB.Text.Trim(),
                            FullName = empNameTB.Text.Trim(),
                            Gender = maleRBtn.Checked ? "Male" : "Female",
                            ContactNumber = empPhoneTB.Text.Trim(),
                            Position = (EmployeePosition)empPositionCBox.SelectedValue,
                            Image = empPictureBox.ImageLocation.ToString(),
                            Salary = 0,
                            Status = activeRBtn.Checked ? "Active" : "Inactive",
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
        private void delete_Btn_Click(object sender, EventArgs e)
        {
            if (empIdTB.Text == ""
             || empNameTB.Text == ""
             || empPhoneTB.Text == "")
            {
                MessageBox.Show(
                "Please select a row that you want to delete.",
                "No Row Selected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else if (employeeCRUD.GetEmployeeByEmpID(empIdTB.Text.Trim()) == null)
            {

                MessageBox.Show($"The Employee ID '{empIdTB.Text.Trim()}' does not exist in the system", "Employee Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                try
                {

                    DialogResult check = MessageBox.Show("Are you sure you want to delete this Employee?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (check == DialogResult.Yes)
                    {
                        employeeCRUD.DeleteByEmpID(empIdTB.Text.Trim());


                        MessageBox.Show(
                        "The employee has been successfully deleted from the system.",
                        "Deletion Successful",
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
        private void import_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK) { imagePath = openFileDialog.FileName; }
                empPictureBox.ImageLocation = imagePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Make Phone TextBox Write number only
        private void empPhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Reject the key press
            }
        }
        private void EmpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = EmpGridView.Rows[e.RowIndex];
                empIdTB.Text = row.Cells[1].Value.ToString();
                empNameTB.Text = row.Cells[2].Value.ToString();
                var gender = row.Cells[3].Value.ToString() == "Male" ? maleRBtn.Checked = true : femaleRBtn.Checked = true;
                empPhoneTB.Text = row.Cells[4].Value.ToString();
                empPositionCBox.SelectedItem = Enum.Parse(typeof(EmployeePosition), row.Cells[5].Value.ToString());
                if (row.Cells[6].Value.ToString() != "System.Drawing.Bitmap" && row.Cells[6].Value.ToString() != "")
                {
                    empPictureBox.ImageLocation = row.Cells[6].Value.ToString();
                }
                else
                {
                    empPictureBox.Image = empPictureBox.InitialImage;
                }

                var status = row.Cells[8].Value.ToString() == "Active" ? activeRBtn.Checked = true : inactiveRBtn.Checked = true;
            }
        }


    }
}
