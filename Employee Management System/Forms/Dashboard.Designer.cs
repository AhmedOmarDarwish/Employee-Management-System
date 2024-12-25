namespace Employee_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel5 = new Panel();
            InEmployee = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            AEmployee = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            TEmployee = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 230, 237);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(20, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 160);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(82, 109, 130);
            panel5.Controls.Add(InEmployee);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(537, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 120);
            panel5.TabIndex = 13;
            // 
            // InEmployee
            // 
            InEmployee.AutoSize = true;
            InEmployee.Font = new Font("AF_Hijaz", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 178);
            InEmployee.ForeColor = Color.White;
            InEmployee.Location = new Point(175, 22);
            InEmployee.Name = "InEmployee";
            InEmployee.Size = new Size(49, 38);
            InEmployee.TabIndex = 12;
            InEmployee.Text = "00";
            InEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("AF_Hijaz", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label5.ForeColor = Color.White;
            label5.Location = new Point(81, 86);
            label5.Name = "label5";
            label5.Size = new Size(156, 24);
            label5.TabIndex = 10;
            label5.Text = "Inactive Employee";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(2, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 69);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(82, 109, 130);
            panel4.Controls.Add(AEmployee);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(283, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 120);
            panel4.TabIndex = 13;
            // 
            // AEmployee
            // 
            AEmployee.AutoSize = true;
            AEmployee.Font = new Font("AF_Hijaz", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 178);
            AEmployee.ForeColor = Color.White;
            AEmployee.Location = new Point(175, 22);
            AEmployee.Name = "AEmployee";
            AEmployee.Size = new Size(49, 38);
            AEmployee.TabIndex = 12;
            AEmployee.Text = "00";
            AEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("AF_Hijaz", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.White;
            label3.Location = new Point(83, 86);
            label3.Name = "label3";
            label3.Size = new Size(142, 24);
            label3.TabIndex = 10;
            label3.Text = "Active Employee";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(2, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(82, 109, 130);
            panel3.Controls.Add(TEmployee);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(28, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 120);
            panel3.TabIndex = 0;
            // 
            // TEmployee
            // 
            TEmployee.AutoSize = true;
            TEmployee.Font = new Font("AF_Hijaz", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 178);
            TEmployee.ForeColor = Color.White;
            TEmployee.Location = new Point(175, 22);
            TEmployee.Name = "TEmployee";
            TEmployee.Size = new Size(49, 38);
            TEmployee.TabIndex = 12;
            TEmployee.Text = "00";
            TEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("AF_Hijaz", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.White;
            label6.Location = new Point(83, 86);
            label6.Name = "label6";
            label6.Size = new Size(133, 24);
            label6.TabIndex = 10;
            label6.Text = "Total Employee";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(2, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(221, 230, 237);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(20, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 336);
            panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(850, 550);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox1;
        private Label TEmployee;
        private Panel panel5;
        private Label InEmployee;
        private Label label5;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Label AEmployee;
        private Label label3;
        private PictureBox pictureBox2;
    }
}
