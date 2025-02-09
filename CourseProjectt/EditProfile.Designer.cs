namespace CourseProjectt
{
    partial class EditProfile
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
            pic_image = new PictureBox();
            txt_regusername = new TextBox();
            txt_regaddress = new TextBox();
            Num_grade = new NumericUpDown();
            txt_regphone = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            txt_confpassword = new TextBox();
            button1 = new Button();
            showpass = new CheckBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pic_image
            // 
            pic_image.Location = new Point(446, 12);
            pic_image.Name = "pic_image";
            pic_image.Size = new Size(139, 63);
            pic_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_image.TabIndex = 35;
            pic_image.TabStop = false;
            pic_image.Click += pic_image_Click;
            pic_image.Paint += pic_image_Paint;
            // 
            // txt_regusername
            // 
            txt_regusername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_regusername.Location = new Point(442, 89);
            txt_regusername.Margin = new Padding(2);
            txt_regusername.Multiline = true;
            txt_regusername.Name = "txt_regusername";
            txt_regusername.Size = new Size(214, 30);
            txt_regusername.TabIndex = 51;
            // 
            // txt_regaddress
            // 
            txt_regaddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_regaddress.Location = new Point(442, 133);
            txt_regaddress.Margin = new Padding(2);
            txt_regaddress.Multiline = true;
            txt_regaddress.Name = "txt_regaddress";
            txt_regaddress.Size = new Size(214, 30);
            txt_regaddress.TabIndex = 50;
            // 
            // Num_grade
            // 
            Num_grade.Location = new Point(442, 177);
            Num_grade.Margin = new Padding(2);
            Num_grade.Name = "Num_grade";
            Num_grade.Size = new Size(67, 23);
            Num_grade.TabIndex = 49;
            // 
            // txt_regphone
            // 
            txt_regphone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_regphone.Location = new Point(442, 213);
            txt_regphone.Margin = new Padding(2);
            txt_regphone.Multiline = true;
            txt_regphone.Name = "txt_regphone";
            txt_regphone.Size = new Size(214, 30);
            txt_regphone.TabIndex = 48;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(442, 256);
            txt_email.Margin = new Padding(2);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(214, 30);
            txt_email.TabIndex = 47;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(442, 299);
            txt_password.Margin = new Padding(2);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(214, 30);
            txt_password.TabIndex = 46;
            // 
            // txt_confpassword
            // 
            txt_confpassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_confpassword.Location = new Point(442, 342);
            txt_confpassword.Margin = new Padding(2);
            txt_confpassword.Multiline = true;
            txt_confpassword.Name = "txt_confpassword";
            txt_confpassword.PasswordChar = '*';
            txt_confpassword.Size = new Size(214, 30);
            txt_confpassword.TabIndex = 45;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(3, 14, 28);
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(431, 408);
            button1.Name = "button1";
            button1.Size = new Size(129, 36);
            button1.TabIndex = 44;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // showpass
            // 
            showpass.AutoSize = true;
            showpass.Location = new Point(442, 377);
            showpass.Name = "showpass";
            showpass.Size = new Size(104, 19);
            showpass.TabIndex = 43;
            showpass.Text = "showpassword";
            showpass.UseVisualStyleBackColor = true;
            showpass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(312, 56);
            label10.Name = "label10";
            label10.Size = new Size(49, 19);
            label10.TabIndex = 42;
            label10.Text = "Image";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(312, 348);
            label9.Name = "label9";
            label9.Size = new Size(123, 19);
            label9.TabIndex = 41;
            label9.Text = "Confirm Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(312, 135);
            label8.Name = "label8";
            label8.Size = new Size(59, 19);
            label8.TabIndex = 40;
            label8.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(312, 177);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 39;
            label6.Text = "grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(312, 215);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 38;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(312, 258);
            label4.Name = "label4";
            label4.Size = new Size(43, 19);
            label4.TabIndex = 37;
            label4.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 301);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 36;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 91);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 34;
            label1.Text = "UserName";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 457);
            panel1.TabIndex = 33;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(3, 14, 28);
            button3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(46, 413);
            button3.Name = "button3";
            button3.Size = new Size(207, 31);
            button3.TabIndex = 16;
            button3.Text = "Go to Main";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(3, 14, 28);
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(46, 365);
            button2.Name = "button2";
            button2.Size = new Size(207, 31);
            button2.TabIndex = 5;
            button2.Text = "Show Profile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(46, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(3, 14, 28);
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(73, 56);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 32);
            label7.TabIndex = 15;
            label7.Text = "Edit Profile";
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 456);
            Controls.Add(pic_image);
            Controls.Add(txt_regusername);
            Controls.Add(txt_regaddress);
            Controls.Add(Num_grade);
            Controls.Add(txt_regphone);
            Controls.Add(txt_email);
            Controls.Add(txt_password);
            Controls.Add(txt_confpassword);
            Controls.Add(button1);
            Controls.Add(showpass);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pic_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_image;
        private TextBox txt_regusername;
        private TextBox txt_regaddress;
        private NumericUpDown Num_grade;
        private TextBox txt_regphone;
        private TextBox txt_email;
        private TextBox txt_password;
        private TextBox txt_confpassword;
        private Button button1;
        private CheckBox showpass;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label7;
        private Button button3;
    }
}