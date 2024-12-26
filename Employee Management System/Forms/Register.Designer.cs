namespace Employee_Management_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            Register_Confirm_Password = new TextBox();
            label1 = new Label();
            Signup_Btn = new Button();
            register_showPass = new CheckBox();
            Register_Password = new TextBox();
            Register_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Exit = new Label();
            panel2 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            login_signupBtn = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Register_Confirm_Password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Signup_Btn);
            panel1.Controls.Add(register_showPass);
            panel1.Controls.Add(Register_Password);
            panel1.Controls.Add(Register_username);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(267, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 400);
            panel1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(176, 232);
            label9.Name = "label9";
            label9.Size = new Size(15, 16);
            label9.TabIndex = 20;
            label9.Text = "*";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(107, 169);
            label8.Name = "label8";
            label8.Size = new Size(15, 16);
            label8.TabIndex = 19;
            label8.Text = "*";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(120, 106);
            label7.Name = "label7";
            label7.Size = new Size(15, 16);
            label7.TabIndex = 18;
            label7.Text = "*";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register_Confirm_Password
            // 
            Register_Confirm_Password.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Register_Confirm_Password.Location = new Point(16, 262);
            Register_Confirm_Password.Multiline = true;
            Register_Confirm_Password.Name = "Register_Confirm_Password";
            Register_Confirm_Password.PasswordChar = '*';
            Register_Confirm_Password.Size = new Size(265, 30);
            Register_Confirm_Password.TabIndex = 14;
            Register_Confirm_Password.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label1.Location = new Point(14, 237);
            label1.Name = "label1";
            label1.Size = new Size(167, 19);
            label1.TabIndex = 16;
            label1.Text = "Confirm Password :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Signup_Btn
            // 
            Signup_Btn.BackColor = Color.FromArgb(39, 55, 77);
            Signup_Btn.Cursor = Cursors.Hand;
            Signup_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            Signup_Btn.FlatStyle = FlatStyle.Flat;
            Signup_Btn.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signup_Btn.ForeColor = Color.White;
            Signup_Btn.Location = new Point(17, 336);
            Signup_Btn.Name = "Signup_Btn";
            Signup_Btn.Size = new Size(264, 40);
            Signup_Btn.TabIndex = 16;
            Signup_Btn.Text = "SIGNUP";
            Signup_Btn.UseVisualStyleBackColor = false;
            Signup_Btn.Click += signup_Btn_Click;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Segoe UI", 8.139131F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_showPass.Location = new Point(163, 298);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(122, 21);
            register_showPass.TabIndex = 15;
            register_showPass.Text = "Show Password";
            register_showPass.TextAlign = ContentAlignment.MiddleCenter;
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // Register_Password
            // 
            Register_Password.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Register_Password.Location = new Point(16, 199);
            Register_Password.Multiline = true;
            Register_Password.Name = "Register_Password";
            Register_Password.PasswordChar = '*';
            Register_Password.Size = new Size(265, 30);
            Register_Password.TabIndex = 13;
            // 
            // Register_username
            // 
            Register_username.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Register_username.Location = new Point(17, 136);
            Register_username.Multiline = true;
            Register_username.Name = "Register_username";
            Register_username.Size = new Size(265, 30);
            Register_username.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label4.Location = new Point(14, 173);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 11;
            label4.Text = "Password :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label3.Location = new Point(16, 106);
            label3.Name = "label3";
            label3.Size = new Size(109, 19);
            label3.TabIndex = 10;
            label3.Text = "User Name :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(237, 31);
            label2.TabIndex = 9;
            label2.Text = "Register Account";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Cursor = Cursors.Hand;
            Exit.Font = new Font("SKR HEAD2 Outlined", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Exit.ForeColor = Color.FromArgb(39, 55, 77);
            Exit.Location = new Point(263, 5);
            Exit.Name = "Exit";
            Exit.Size = new Size(41, 43);
            Exit.TabIndex = 8;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 55, 77);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(login_signupBtn);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 400);
            panel2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("AF_Hijaz", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.White;
            label6.Location = new Point(41, 195);
            label6.Name = "label6";
            label6.Size = new Size(186, 29);
            label6.TabIndex = 8;
            label6.Text = "Employee System";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(65, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.WhiteSmoke;
            login_signupBtn.Cursor = Cursors.Hand;
            login_signupBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 230, 237);
            login_signupBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 230, 237);
            login_signupBtn.FlatStyle = FlatStyle.Flat;
            login_signupBtn.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_signupBtn.ForeColor = Color.FromArgb(39, 55, 77);
            login_signupBtn.Location = new Point(23, 335);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(220, 40);
            login_signupBtn.TabIndex = 8;
            login_signupBtn.Text = "LOGIN";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8.139131F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(80, 307);
            label5.Name = "label5";
            label5.Size = new Size(118, 16);
            label5.TabIndex = 8;
            label5.Text = "Have an Account";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AcceptButton = Signup_Btn;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 400);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private PictureBox pictureBox1;
        private Button login_signupBtn;
        private Label label5;
        private Button Signup_Btn;
        private CheckBox register_showPass;
        private TextBox Register_Password;
        private TextBox Register_username;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Exit;
        private TextBox Register_Confirm_Password;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}