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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            panel2 = new Panel();
            Stuts_CBox = new ComboBox();
            label7 = new Label();
            Gender_CBox = new ComboBox();
            label5 = new Label();
            Clear_Btn = new Button();
            Delete_Btn = new Button();
            Update_Btn = new Button();
            Add_Btn = new Button();
            import_Btn = new Button();
            addEmp_picture = new PictureBox();
            addEmp_position = new ComboBox();
            label4 = new Label();
            addEmp_PhoneNumber = new TextBox();
            label2 = new Label();
            addEmp_FullName = new TextBox();
            label1 = new Label();
            addEmp_ID = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addEmp_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 230, 237);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(26, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 273);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(157, 178, 191);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(39, 55, 77);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(157, 178, 191);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(18, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(762, 206);
            dataGridView1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("AF_Hijaz", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.FromArgb(39, 55, 77);
            label6.Location = new Point(21, 13);
            label6.Name = "label6";
            label6.Size = new Size(175, 29);
            label6.TabIndex = 11;
            label6.Text = "Employee's Data";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(221, 230, 237);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Stuts_CBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(Gender_CBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Clear_Btn);
            panel2.Controls.Add(Delete_Btn);
            panel2.Controls.Add(Update_Btn);
            panel2.Controls.Add(Add_Btn);
            panel2.Controls.Add(import_Btn);
            panel2.Controls.Add(addEmp_picture);
            panel2.Controls.Add(addEmp_position);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addEmp_PhoneNumber);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(addEmp_FullName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(addEmp_ID);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(26, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 239);
            panel2.TabIndex = 1;
            // 
            // Stuts_CBox
            // 
            Stuts_CBox.FormattingEnabled = true;
            Stuts_CBox.Items.AddRange(new object[] { "Active", "Inactive" });
            Stuts_CBox.Location = new Point(333, 147);
            Stuts_CBox.Name = "Stuts_CBox";
            Stuts_CBox.Size = new Size(230, 27);
            Stuts_CBox.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label7.Location = new Point(333, 125);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 31;
            label7.Text = "Status:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Gender_CBox
            // 
            Gender_CBox.FormattingEnabled = true;
            Gender_CBox.Location = new Point(333, 37);
            Gender_CBox.Name = "Gender_CBox";
            Gender_CBox.Size = new Size(230, 27);
            Gender_CBox.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label5.Location = new Point(333, 10);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 29;
            label5.Text = "Gender:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Clear_Btn
            // 
            Clear_Btn.BackColor = Color.FromArgb(39, 55, 77);
            Clear_Btn.Cursor = Cursors.Hand;
            Clear_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            Clear_Btn.FlatStyle = FlatStyle.Flat;
            Clear_Btn.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear_Btn.ForeColor = Color.White;
            Clear_Btn.Location = new Point(491, 185);
            Clear_Btn.Name = "Clear_Btn";
            Clear_Btn.Size = new Size(133, 43);
            Clear_Btn.TabIndex = 28;
            Clear_Btn.Text = "Clear";
            Clear_Btn.UseVisualStyleBackColor = false;
            // 
            // Delete_Btn
            // 
            Delete_Btn.BackColor = Color.FromArgb(39, 55, 77);
            Delete_Btn.Cursor = Cursors.Hand;
            Delete_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            Delete_Btn.FlatStyle = FlatStyle.Flat;
            Delete_Btn.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_Btn.ForeColor = Color.White;
            Delete_Btn.Location = new Point(333, 184);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(133, 43);
            Delete_Btn.TabIndex = 27;
            Delete_Btn.Text = "Delete";
            Delete_Btn.UseVisualStyleBackColor = false;
            // 
            // Update_Btn
            // 
            Update_Btn.BackColor = Color.FromArgb(39, 55, 77);
            Update_Btn.Cursor = Cursors.Hand;
            Update_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            Update_Btn.FlatStyle = FlatStyle.Flat;
            Update_Btn.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_Btn.ForeColor = Color.White;
            Update_Btn.Location = new Point(177, 184);
            Update_Btn.Name = "Update_Btn";
            Update_Btn.Size = new Size(133, 43);
            Update_Btn.TabIndex = 26;
            Update_Btn.Text = "Update";
            Update_Btn.UseVisualStyleBackColor = false;
            // 
            // Add_Btn
            // 
            Add_Btn.BackColor = Color.FromArgb(39, 55, 77);
            Add_Btn.Cursor = Cursors.Hand;
            Add_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            Add_Btn.FlatStyle = FlatStyle.Flat;
            Add_Btn.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Btn.ForeColor = Color.White;
            Add_Btn.Location = new Point(23, 184);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(133, 43);
            Add_Btn.TabIndex = 25;
            Add_Btn.Text = "Add";
            Add_Btn.UseVisualStyleBackColor = false;
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
            import_Btn.TabIndex = 23;
            import_Btn.Text = "Import";
            import_Btn.UseVisualStyleBackColor = false;
            // 
            // addEmp_picture
            // 
            addEmp_picture.BackColor = Color.FromArgb(157, 178, 191);
            addEmp_picture.BorderStyle = BorderStyle.FixedSingle;
            addEmp_picture.Location = new Point(647, 35);
            addEmp_picture.Name = "addEmp_picture";
            addEmp_picture.Size = new Size(133, 141);
            addEmp_picture.TabIndex = 22;
            addEmp_picture.TabStop = false;
            // 
            // addEmp_position
            // 
            addEmp_position.FormattingEnabled = true;
            addEmp_position.Location = new Point(333, 92);
            addEmp_position.Name = "addEmp_position";
            addEmp_position.Size = new Size(230, 27);
            addEmp_position.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label4.Location = new Point(333, 68);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 19;
            label4.Text = "Position :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addEmp_PhoneNumber
            // 
            addEmp_PhoneNumber.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmp_PhoneNumber.Location = new Point(21, 147);
            addEmp_PhoneNumber.Multiline = true;
            addEmp_PhoneNumber.Name = "addEmp_PhoneNumber";
            addEmp_PhoneNumber.Size = new Size(230, 30);
            addEmp_PhoneNumber.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label2.Location = new Point(21, 125);
            label2.Name = "label2";
            label2.Size = new Size(140, 19);
            label2.TabIndex = 17;
            label2.Text = "Phone Number :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addEmp_FullName
            // 
            addEmp_FullName.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmp_FullName.Location = new Point(22, 91);
            addEmp_FullName.Multiline = true;
            addEmp_FullName.Name = "addEmp_FullName";
            addEmp_FullName.Size = new Size(230, 30);
            addEmp_FullName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label1.Location = new Point(21, 68);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 15;
            label1.Text = "Full Name :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addEmp_ID
            // 
            addEmp_ID.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmp_ID.Location = new Point(21, 34);
            addEmp_ID.Multiline = true;
            addEmp_ID.Name = "addEmp_ID";
            addEmp_ID.Size = new Size(230, 30);
            addEmp_ID.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label3.Location = new Point(20, 10);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 13;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addEmp_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private DataGridView dataGridView1;
        private ComboBox addEmp_position;
        private Label label4;
        private TextBox addEmp_PhoneNumber;
        private Label label2;
        private TextBox addEmp_FullName;
        private Label label1;
        private TextBox addEmp_ID;
        private Label label3;
        private PictureBox addEmp_picture;
        private Button Add_Btn;
        private Button import_Btn;
        private Button Clear_Btn;
        private Button Delete_Btn;
        private Button Update_Btn;
        private ComboBox Stuts_CBox;
        private Label label7;
        private ComboBox Gender_CBox;
        private Label label5;
    }
}
