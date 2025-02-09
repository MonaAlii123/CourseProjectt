namespace CourseProjectt
{
    partial class Login
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
            panel1 = new Panel();
            label3 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            login_showPass = new CheckBox();
            txt_username = new TextBox();
            txt_password = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 457);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(71, 358);
            label3.Name = "label3";
            label3.Size = new Size(142, 16);
            label3.TabIndex = 6;
            label3.Text = "Create New Account?";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(3, 14, 28);
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(37, 377);
            button2.Name = "button2";
            button2.Size = new Size(207, 31);
            button2.TabIndex = 5;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image1;
            pictureBox1.Location = new Point(91, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(404, 67);
            label4.Name = "label4";
            label4.Size = new Size(146, 17);
            label4.TabIndex = 8;
            label4.Text = "Welcome back,user";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(3, 14, 28);
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(430, 320);
            button1.Name = "button1";
            button1.Size = new Size(129, 36);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 171);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 10;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 216);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Location = new Point(404, 249);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(104, 19);
            login_showPass.TabIndex = 14;
            login_showPass.Text = "showpassword";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(406, 169);
            txt_username.Margin = new Padding(2);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(224, 30);
            txt_username.TabIndex = 15;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(406, 214);
            txt_password.Margin = new Padding(2);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(224, 30);
            txt_password.TabIndex = 16;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 456);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(login_showPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button1;
        private Label label1;
        private Label label2;
        private CheckBox login_showPass;
        private TextBox txt_username;
        private TextBox txt_password;
    }
}