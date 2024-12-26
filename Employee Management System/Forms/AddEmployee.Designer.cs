namespace Employee_Management_System
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            panel1 = new Panel();
            EmpGridView = new DataGridView();
            label6 = new Label();
            panel2 = new Panel();
            statusPanel = new Panel();
            inactiveRBtn = new RadioButton();
            activeRBtn = new RadioButton();
            genderPanel = new Panel();
            maleRBtn = new RadioButton();
            femaleRBtn = new RadioButton();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            clear_Btn = new Button();
            delete_Btn = new Button();
            update_Btn = new Button();
            add_Btn = new Button();
            import_Btn = new Button();
            empPictureBox = new PictureBox();
            empPositionCBox = new ComboBox();
            label4 = new Label();
            empPhoneTB = new TextBox();
            label2 = new Label();
            empSalaryTB = new TextBox();
            label1 = new Label();
            empIdTB = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpGridView).BeginInit();
            panel2.SuspendLayout();
            statusPanel.SuspendLayout();
            genderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 230, 237);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(EmpGridView);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(26, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 273);
            panel1.TabIndex = 0;
            // 
            // EmpGridView
            // 
            EmpGridView.AllowUserToAddRows = false;
            EmpGridView.AllowUserToDeleteRows = false;
            EmpGridView.BackgroundColor = Color.FromArgb(157, 178, 191);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(39, 55, 77);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(157, 178, 191);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmpGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmpGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpGridView.EnableHeadersVisualStyles = false;
            EmpGridView.Location = new Point(18, 46);
            EmpGridView.Name = "EmpGridView";
            EmpGridView.ReadOnly = true;
            EmpGridView.RowHeadersWidth = 49;
            EmpGridView.Size = new Size(762, 206);
            EmpGridView.TabIndex = 0;
            EmpGridView.CellClick += EmpGridView_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("AF_Hijaz", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.FromArgb(39, 55, 77);
            label6.Location = new Point(21, 13);
            label6.Name = "label6";
            label6.Size = new Size(175, 29);
            label6.TabIndex = 0;
            label6.Text = "Employee's Data";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(221, 230, 237);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(statusPanel);
            panel2.Controls.Add(genderPanel);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(clear_Btn);
            panel2.Controls.Add(delete_Btn);
            panel2.Controls.Add(update_Btn);
            panel2.Controls.Add(add_Btn);
            panel2.Controls.Add(import_Btn);
            panel2.Controls.Add(empPictureBox);
            panel2.Controls.Add(empPositionCBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(empPhoneTB);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(empSalaryTB);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(empIdTB);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(26, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 239);
            panel2.TabIndex = 0;
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(inactiveRBtn);
            statusPanel.Controls.Add(activeRBtn);
            statusPanel.Location = new Point(386, 147);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(208, 29);
            statusPanel.TabIndex = 40;
            // 
            // inactiveRBtn
            // 
            inactiveRBtn.AutoSize = true;
            inactiveRBtn.Location = new Point(127, 2);
            inactiveRBtn.Name = "inactiveRBtn";
            inactiveRBtn.Size = new Size(78, 24);
            inactiveRBtn.TabIndex = 8;
            inactiveRBtn.Text = "Inactive";
            inactiveRBtn.UseVisualStyleBackColor = true;
            // 
            // activeRBtn
            // 
            activeRBtn.AutoSize = true;
            activeRBtn.Checked = true;
            activeRBtn.Location = new Point(3, 3);
            activeRBtn.Name = "activeRBtn";
            activeRBtn.Size = new Size(68, 24);
            activeRBtn.TabIndex = 7;
            activeRBtn.TabStop = true;
            activeRBtn.Text = "Active";
            activeRBtn.UseVisualStyleBackColor = true;
            // 
            // genderPanel
            // 
            genderPanel.Controls.Add(maleRBtn);
            genderPanel.Controls.Add(femaleRBtn);
            genderPanel.Location = new Point(381, 34);
            genderPanel.Name = "genderPanel";
            genderPanel.Size = new Size(208, 29);
            genderPanel.TabIndex = 39;
            // 
            // maleRBtn
            // 
            maleRBtn.AutoSize = true;
            maleRBtn.Checked = true;
            maleRBtn.Location = new Point(4, 2);
            maleRBtn.Name = "maleRBtn";
            maleRBtn.Size = new Size(60, 24);
            maleRBtn.TabIndex = 4;
            maleRBtn.TabStop = true;
            maleRBtn.Text = "Male";
            maleRBtn.UseVisualStyleBackColor = true;
            // 
            // femaleRBtn
            // 
            femaleRBtn.AutoSize = true;
            femaleRBtn.Location = new Point(127, 2);
            femaleRBtn.Name = "femaleRBtn";
            femaleRBtn.Size = new Size(75, 24);
            femaleRBtn.TabIndex = 5;
            femaleRBtn.Text = "Female";
            femaleRBtn.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(398, 122);
            label13.Name = "label13";
            label13.Size = new Size(15, 16);
            label13.TabIndex = 38;
            label13.Text = "*";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(416, 67);
            label12.Name = "label12";
            label12.Size = new Size(15, 16);
            label12.TabIndex = 37;
            label12.Text = "*";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(404, 11);
            label11.Name = "label11";
            label11.Size = new Size(15, 16);
            label11.TabIndex = 36;
            label11.Text = "*";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(159, 124);
            label10.Name = "label10";
            label10.Size = new Size(15, 16);
            label10.TabIndex = 35;
            label10.Text = "*";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(119, 68);
            label8.Name = "label8";
            label8.Size = new Size(15, 16);
            label8.TabIndex = 34;
            label8.Text = "*";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(141, 10);
            label9.Name = "label9";
            label9.Size = new Size(15, 16);
            label9.TabIndex = 33;
            label9.Text = "*";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label7.Location = new Point(333, 125);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 0;
            label7.Text = "Status:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label5.Location = new Point(333, 10);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 0;
            label5.Text = "Gender:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clear_Btn
            // 
            clear_Btn.BackColor = Color.FromArgb(39, 55, 77);
            clear_Btn.Cursor = Cursors.Hand;
            clear_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            clear_Btn.FlatStyle = FlatStyle.Flat;
            clear_Btn.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear_Btn.ForeColor = Color.White;
            clear_Btn.Location = new Point(491, 185);
            clear_Btn.Name = "clear_Btn";
            clear_Btn.Size = new Size(133, 43);
            clear_Btn.TabIndex = 13;
            clear_Btn.Text = "Clear";
            clear_Btn.UseVisualStyleBackColor = false;
            clear_Btn.Click += clear_Btn_Click;
            // 
            // delete_Btn
            // 
            delete_Btn.BackColor = Color.FromArgb(39, 55, 77);
            delete_Btn.Cursor = Cursors.Hand;
            delete_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            delete_Btn.FlatStyle = FlatStyle.Flat;
            delete_Btn.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_Btn.ForeColor = Color.White;
            delete_Btn.Location = new Point(333, 184);
            delete_Btn.Name = "delete_Btn";
            delete_Btn.Size = new Size(133, 43);
            delete_Btn.TabIndex = 12;
            delete_Btn.Text = "Delete";
            delete_Btn.UseVisualStyleBackColor = false;
            delete_Btn.Click += delete_Btn_Click;
            // 
            // update_Btn
            // 
            update_Btn.BackColor = Color.FromArgb(39, 55, 77);
            update_Btn.Cursor = Cursors.Hand;
            update_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            update_Btn.FlatStyle = FlatStyle.Flat;
            update_Btn.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_Btn.ForeColor = Color.White;
            update_Btn.Location = new Point(177, 184);
            update_Btn.Name = "update_Btn";
            update_Btn.Size = new Size(133, 43);
            update_Btn.TabIndex = 11;
            update_Btn.Text = "Update";
            update_Btn.UseVisualStyleBackColor = false;
            update_Btn.Click += Update_Btn_Click;
            // 
            // add_Btn
            // 
            add_Btn.BackColor = Color.FromArgb(39, 55, 77);
            add_Btn.Cursor = Cursors.Hand;
            add_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            add_Btn.FlatStyle = FlatStyle.Flat;
            add_Btn.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_Btn.ForeColor = Color.White;
            add_Btn.Location = new Point(23, 184);
            add_Btn.Name = "add_Btn";
            add_Btn.Size = new Size(133, 43);
            add_Btn.TabIndex = 10;
            add_Btn.Text = "Add";
            add_Btn.UseVisualStyleBackColor = false;
            add_Btn.Click += add_Btn_Click;
            // 
            // import_Btn
            // 
            import_Btn.BackColor = Color.FromArgb(39, 55, 77);
            import_Btn.Cursor = Cursors.Hand;
            import_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            import_Btn.FlatStyle = FlatStyle.Flat;
            import_Btn.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point, 0);
            import_Btn.ForeColor = Color.White;
            import_Btn.Location = new Point(653, 182);
            import_Btn.Name = "import_Btn";
            import_Btn.Size = new Size(120, 28);
            import_Btn.TabIndex = 9;
            import_Btn.Text = "Import";
            import_Btn.UseVisualStyleBackColor = false;
            import_Btn.Click += import_Btn_Click;
            // 
            // empPictureBox
            // 
            empPictureBox.BackColor = Color.FromArgb(157, 178, 191);
            empPictureBox.BackgroundImageLayout = ImageLayout.None;
            empPictureBox.BorderStyle = BorderStyle.FixedSingle;
            empPictureBox.ErrorImage = (Image)resources.GetObject("empPictureBox.ErrorImage");
            empPictureBox.Image = (Image)resources.GetObject("empPictureBox.Image");
            empPictureBox.InitialImage = (Image)resources.GetObject("empPictureBox.InitialImage");
            empPictureBox.Location = new Point(647, 35);
            empPictureBox.Name = "empPictureBox";
            empPictureBox.Size = new Size(133, 141);
            empPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            empPictureBox.TabIndex = 22;
            empPictureBox.TabStop = false;
            // 
            // empPositionCBox
            // 
            empPositionCBox.FormattingEnabled = true;
            empPositionCBox.Location = new Point(333, 92);
            empPositionCBox.MaxLength = 50;
            empPositionCBox.Name = "empPositionCBox";
            empPositionCBox.Size = new Size(230, 27);
            empPositionCBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label4.Location = new Point(333, 68);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 0;
            label4.Text = "Position :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // empPhoneTB
            // 
            empPhoneTB.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empPhoneTB.Location = new Point(21, 147);
            empPhoneTB.MaxLength = 11;
            empPhoneTB.Multiline = true;
            empPhoneTB.Name = "empPhoneTB";
            empPhoneTB.Size = new Size(230, 30);
            empPhoneTB.TabIndex = 3;
            empPhoneTB.KeyPress += empPhoneTB_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label2.Location = new Point(21, 125);
            label2.Name = "label2";
            label2.Size = new Size(140, 19);
            label2.TabIndex = 0;
            label2.Text = "Phone Number :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // empSalaryTB
            // 
            empSalaryTB.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empSalaryTB.Location = new Point(22, 91);
            empSalaryTB.MaxLength = 100;
            empSalaryTB.Multiline = true;
            empSalaryTB.Name = "empSalaryTB";
            empSalaryTB.Size = new Size(230, 30);
            empSalaryTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label1.Location = new Point(21, 68);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 0;
            label1.Text = "Full Name :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // empIdTB
            // 
            empIdTB.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empIdTB.Location = new Point(21, 34);
            empIdTB.MaxLength = 50;
            empIdTB.Multiline = true;
            empIdTB.Name = "empIdTB";
            empIdTB.Size = new Size(230, 30);
            empIdTB.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label3.Location = new Point(20, 10);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 0;
            label3.Text = "Employee ID :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(850, 550);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            genderPanel.ResumeLayout(false);
            genderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)empPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private DataGridView EmpGridView;
        private ComboBox empPositionCBox;
        private Label label4;
        private TextBox empPhoneTB;
        private Label label2;
        private TextBox empNameTB;
        private Label label1;
        private TextBox empIdTB;
        private Label label3;
        private PictureBox empPictureBox;
        private Button add_Btn;
        private Button import_Btn;
        private Button clear_Btn;
        private Button delete_Btn;
        private Button update_Btn;
        private Label label7;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private RadioButton femaleRBtn;
        private RadioButton maleRBtn;
        private Label label13;
        private Label label12;
        private RadioButton inactiveRBtn;
        private RadioButton activeRBtn;
        private Panel genderPanel;
        private Panel statusPanel;
        private TextBox empSalaryTB;
    }
}
