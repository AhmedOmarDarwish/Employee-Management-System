
namespace Employee_Management_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            label9 = new Label();
            login_Btn = new Button();
            login_showPass = new CheckBox();
            login_password = new TextBox();
            login_username = new TextBox();
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(login_Btn);
            panel1.Controls.Add(login_showPass);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 400);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(377, 218);
            label1.Name = "label1";
            label1.Size = new Size(15, 16);
            label1.TabIndex = 22;
            label1.Text = "*";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(391, 133);
            label9.Name = "label9";
            label9.Size = new Size(15, 16);
            label9.TabIndex = 21;
            label9.Text = "*";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_Btn
            // 
            login_Btn.BackColor = Color.FromArgb(39, 55, 77);
            login_Btn.Cursor = Cursors.Hand;
            login_Btn.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            login_Btn.FlatStyle = FlatStyle.Flat;
            login_Btn.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Btn.ForeColor = Color.White;
            login_Btn.Location = new Point(287, 336);
            login_Btn.Name = "login_Btn";
            login_Btn.Size = new Size(264, 40);
            login_Btn.TabIndex = 7;
            login_Btn.Text = "LOGIN";
            login_Btn.UseVisualStyleBackColor = false;
            login_Btn.Click += login_Btn_Click;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Segoe UI", 8.139131F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(433, 284);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(122, 21);
            login_showPass.TabIndex = 6;
            login_showPass.Text = "Show Password";
            login_showPass.TextAlign = ContentAlignment.MiddleCenter;
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += loginPassword_CheckedChanged;
            // 
            // login_password
            // 
            login_password.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(286, 244);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(265, 30);
            login_password.TabIndex = 5;
            // 
            // login_username
            // 
            login_username.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(287, 163);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(265, 30);
            login_username.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label4.Location = new Point(284, 218);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 3;
            label4.Text = "Password :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.0173912F, FontStyle.Bold);
            label3.Location = new Point(286, 133);
            label3.Name = "label3";
            label3.Size = new Size(109, 19);
            label3.TabIndex = 2;
            label3.Text = "User Name :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.Location = new Point(282, 58);
            label2.Name = "label2";
            label2.Size = new Size(201, 31);
            label2.TabIndex = 1;
            label2.Text = "Login Account";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Cursor = Cursors.Hand;
            Exit.Font = new Font("SKR HEAD2 Outlined", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Exit.ForeColor = Color.FromArgb(39, 55, 77);
            Exit.Location = new Point(533, 5);
            Exit.Name = "Exit";
            Exit.Size = new Size(41, 43);
            Exit.TabIndex = 0;
            Exit.Text = "X";
            Exit.Click += exit_Click;
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
            panel2.TabIndex = 1;
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
            login_signupBtn.Text = "SIGNUP";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8.139131F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(55, 309);
            label5.Name = "label5";
            label5.Size = new Size(151, 16);
            label5.TabIndex = 8;
            label5.Text = "Register New Account";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AcceptButton = login_Btn;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 400);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void loginPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Exit;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox login_username;
        private TextBox login_password;
        private CheckBox login_showPass;
        private Button login_Btn;
        private Button login_signupBtn;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label1;
        private Label label9;
    }
}
