namespace Employee_Management_System
{
    partial class Salary
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
            empSalaryUN = new NumericUpDown();
            label2 = new Label();
            clearBtn = new Button();
            updateBtn = new Button();
            empIdTB = new TextBox();
            label3 = new Label();
            empNameTB = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            EmpGridView = new DataGridView();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empSalaryUN).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 230, 237);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(empSalaryUN);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(empIdTB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(empNameTB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 383);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 122);
            panel1.TabIndex = 0;
            // 
            // empSalaryUN
            // 
            empSalaryUN.DecimalPlaces = 2;
            empSalaryUN.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empSalaryUN.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            empSalaryUN.Location = new Point(527, 35);
            empSalaryUN.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            empSalaryUN.Name = "empSalaryUN";
            empSalaryUN.Size = new Size(230, 26);
            empSalaryUN.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label2.Location = new Point(527, 8);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 39;
            label2.Text = "Salary :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(39, 55, 77);
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(564, 71);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(133, 43);
            clearBtn.TabIndex = 32;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click_1;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(39, 55, 77);
            updateBtn.Cursor = Cursors.Hand;
            updateBtn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(135, 71);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(133, 43);
            updateBtn.TabIndex = 31;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // empIdTB
            // 
            empIdTB.Enabled = false;
            empIdTB.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empIdTB.Location = new Point(20, 35);
            empIdTB.Multiline = true;
            empIdTB.Name = "empIdTB";
            empIdTB.Size = new Size(230, 30);
            empIdTB.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label3.Location = new Point(19, 8);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 27;
            label3.Text = "Employee ID :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // empNameTB
            // 
            empNameTB.Enabled = false;
            empNameTB.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empNameTB.Location = new Point(271, 35);
            empNameTB.Multiline = true;
            empNameTB.Name = "empNameTB";
            empNameTB.Size = new Size(230, 30);
            empNameTB.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label1.Location = new Point(271, 8);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 29;
            label1.Text = "Full Name :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(221, 230, 237);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(EmpGridView);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(16, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 521);
            panel2.TabIndex = 1;
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
            EmpGridView.Location = new Point(18, 59);
            EmpGridView.Name = "EmpGridView";
            EmpGridView.ReadOnly = true;
            EmpGridView.RowHeadersWidth = 49;
            EmpGridView.Size = new Size(781, 318);
            EmpGridView.TabIndex = 40;
            EmpGridView.CellClick += EmpGridView_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("AF_Hijaz", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.FromArgb(39, 55, 77);
            label6.Location = new Point(18, 17);
            label6.Name = "label6";
            label6.Size = new Size(125, 29);
            label6.TabIndex = 13;
            label6.Text = "Employees ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            Controls.Add(panel2);
            Name = "Salary";
            Size = new Size(850, 550);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)empSalaryUN).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private Button clearBtn;
        private Button updateBtn;
        private TextBox empIdTB;
        private Label label3;
        private TextBox empNameTB;
        private Label label1;
        private Label label2;
        private NumericUpDown empSalaryUN;
        private DataGridView EmpGridView;
    }
}
