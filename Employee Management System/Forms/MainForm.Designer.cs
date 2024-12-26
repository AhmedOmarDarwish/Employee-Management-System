namespace Employee_Management_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label6 = new Label();
            Exit = new Label();
            panel2 = new Panel();
            label2 = new Label();
            Date_Time = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            LogOut = new Button();
            Salary_Btn = new Button();
            AddEmployee_Btn = new Button();
            Dashboard_Btn = new Button();
            Current_User = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dashboard1 = new Dashboard();
            addEmployee1 = new AddEmployee();
            salary1 = new Salary();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 55, 77);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 50);
            panel1.TabIndex = 0;
       
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("AF_Hijaz", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.White;
            label6.Location = new Point(8, 14);
            label6.Name = "label6";
            label6.Size = new Size(228, 21);
            label6.TabIndex = 10;
            label6.Text = "Employee Mangment System";
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Cursor = Cursors.Hand;
            Exit.Font = new Font("SKR HEAD2 Outlined", 18.1565228F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(1056, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 43);
            Exit.TabIndex = 9;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 55, 77);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Date_Time);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(LogOut);
            panel2.Controls.Add(Salary_Btn);
            panel2.Controls.Add(AddEmployee_Btn);
            panel2.Controls.Add(Dashboard_Btn);
            panel2.Controls.Add(Current_User);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 550);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("AF_Hijaz", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.White;
            label2.Location = new Point(67, 502);
            label2.Name = "label2";
            label2.Size = new Size(98, 29);
            label2.TabIndex = 20;
            label2.Text = "Sign Out";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Date_Time
            // 
            Date_Time.Font = new Font("AF_Hijaz", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Date_Time.ForeColor = Color.White;
            Date_Time.Location = new Point(12, 414);
            Date_Time.Name = "Date_Time";
            Date_Time.Size = new Size(228, 27);
            Date_Time.TabIndex = 19;
            Date_Time.Text = "Date & Time";
            Date_Time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(16, 347);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(17, 276);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(18, 206);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.Transparent;
            LogOut.BackgroundImage = (Image)resources.GetObject("LogOut.BackgroundImage");
            LogOut.BackgroundImageLayout = ImageLayout.Stretch;
            LogOut.Cursor = Cursors.Hand;
            LogOut.FlatAppearance.BorderSize = 0;
            LogOut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            LogOut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.ForeColor = Color.Transparent;
            LogOut.Location = new Point(17, 494);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(40, 40);
            LogOut.TabIndex = 15;
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += logOut_Click;
            // 
            // Salary_Btn
            // 
            Salary_Btn.BackColor = Color.Transparent;
            Salary_Btn.Cursor = Cursors.Hand;
            Salary_Btn.FlatAppearance.BorderColor = Color.White;
            Salary_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 230, 237);
            Salary_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 230, 237);
            Salary_Btn.FlatStyle = FlatStyle.Flat;
            Salary_Btn.Font = new Font("Segoe UI Semibold", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salary_Btn.ForeColor = Color.White;
            Salary_Btn.Location = new Point(12, 341);
            Salary_Btn.Name = "Salary_Btn";
            Salary_Btn.Size = new Size(228, 46);
            Salary_Btn.TabIndex = 14;
            Salary_Btn.Text = "SALARY";
            Salary_Btn.UseVisualStyleBackColor = false;
            Salary_Btn.Click += Salary_Btn_Click;
            // 
            // AddEmployee_Btn
            // 
            AddEmployee_Btn.BackColor = Color.Transparent;
            AddEmployee_Btn.Cursor = Cursors.Hand;
            AddEmployee_Btn.FlatAppearance.BorderColor = Color.White;
            AddEmployee_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 230, 237);
            AddEmployee_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 230, 237);
            AddEmployee_Btn.FlatStyle = FlatStyle.Flat;
            AddEmployee_Btn.Font = new Font("Segoe UI Semibold", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddEmployee_Btn.ForeColor = Color.White;
            AddEmployee_Btn.Location = new Point(12, 270);
            AddEmployee_Btn.Name = "AddEmployee_Btn";
            AddEmployee_Btn.Size = new Size(228, 46);
            AddEmployee_Btn.TabIndex = 13;
            AddEmployee_Btn.Text = " ADD EMPLOYEE";
            AddEmployee_Btn.UseVisualStyleBackColor = false;
            AddEmployee_Btn.Click += AddEmployee_Btn_Click;
            // 
            // Dashboard_Btn
            // 
            Dashboard_Btn.BackColor = Color.Transparent;
            Dashboard_Btn.BackgroundImageLayout = ImageLayout.None;
            Dashboard_Btn.Cursor = Cursors.Hand;
            Dashboard_Btn.FlatAppearance.BorderColor = Color.White;
            Dashboard_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 230, 237);
            Dashboard_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 230, 237);
            Dashboard_Btn.FlatStyle = FlatStyle.Flat;
            Dashboard_Btn.Font = new Font("Segoe UI Semibold", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard_Btn.ForeColor = Color.White;
            Dashboard_Btn.Location = new Point(12, 201);
            Dashboard_Btn.Name = "Dashboard_Btn";
            Dashboard_Btn.Size = new Size(228, 46);
            Dashboard_Btn.TabIndex = 12;
            Dashboard_Btn.Text = "DASHBOARD";
            Dashboard_Btn.UseVisualStyleBackColor = false;
            Dashboard_Btn.Click += Dashboard_Btn_Click_1;
            // 
            // Current_User
            // 
            Current_User.Font = new Font("AF_Hijaz", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Current_User.ForeColor = Color.White;
            Current_User.Location = new Point(12, 136);
            Current_User.Name = "Current_User";
            Current_User.Size = new Size(224, 29);
            Current_User.TabIndex = 10;
            Current_User.Text = "Welcome User";
            Current_User.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(64, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(addEmployee1);
            panel3.Controls.Add(salary1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 550);
            panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.FromArgb(157, 178, 191);
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1018, 659);
            dashboard1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            addEmployee1.BackColor = Color.FromArgb(157, 178, 191);
            addEmployee1.Location = new Point(0, 0);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(1018, 659);
            addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            salary1.BackColor = Color.FromArgb(157, 178, 191);
            salary1.Location = new Point(0, 0);
            salary1.Name = "salary1";
            salary1.Size = new Size(1018, 659);
            salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Exit;
        private Label label6;
        private Panel panel2;
        private Label Current_User;
        private PictureBox pictureBox1;
        private Button Dashboard_Btn;
        private Button LogOut;
        private Button Salary_Btn;
        private Button AddEmployee_Btn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label2;
        private Label Date_Time;
        private Panel panel3;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
        private Salary salary1;
    }
}