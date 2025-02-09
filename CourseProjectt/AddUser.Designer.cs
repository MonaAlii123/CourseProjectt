namespace CourseProjectt
{
    partial class AddUser
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
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            dgv_users = new DataGridView();
            cb_dept = new ComboBox();
            Num_grade2 = new NumericUpDown();
            txt_address = new TextBox();
            txt_name = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            txt_email = new TextBox();
            label6 = new Label();
            txt_phone = new TextBox();
            label7 = new Label();
            label2 = new Label();
            txt_password = new TextBox();
            pic_image = new PictureBox();
            label8 = new Label();
            label11 = new Label();
            cb_role = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_image).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 456);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(3, 14, 28);
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(10, 394);
            button2.Name = "button2";
            button2.Size = new Size(127, 35);
            button2.TabIndex = 12;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(3, 14, 28);
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(10, 282);
            button1.Name = "button1";
            button1.Size = new Size(127, 35);
            button1.TabIndex = 11;
            button1.Text = "Course";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(3, 14, 28);
            button4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(10, 340);
            button4.Name = "button4";
            button4.Size = new Size(127, 35);
            button4.TabIndex = 10;
            button4.Text = "Depaertment";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image1;
            pictureBox1.Location = new Point(21, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 14, 28);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(143, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 456);
            panel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(17, 327);
            button3.Name = "button3";
            button3.Size = new Size(113, 35);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumTurquoise;
            button5.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(17, 272);
            button5.Name = "button5";
            button5.Size = new Size(113, 35);
            button5.TabIndex = 10;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumTurquoise;
            button6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(17, 215);
            button6.Name = "button6";
            button6.Size = new Size(113, 35);
            button6.TabIndex = 9;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dgv_users
            // 
            dgv_users.AllowUserToOrderColumns = true;
            dgv_users.BackgroundColor = Color.FromArgb(3, 14, 28);
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.Location = new Point(294, 12);
            dgv_users.Name = "dgv_users";
            dgv_users.Size = new Size(361, 181);
            dgv_users.TabIndex = 0;
            dgv_users.CellContentClick += dgv_users_CellContentClick;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(598, 304);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(57, 23);
            cb_dept.TabIndex = 60;
            // 
            // Num_grade2
            // 
            Num_grade2.Location = new Point(589, 267);
            Num_grade2.Margin = new Padding(2);
            Num_grade2.Name = "Num_grade2";
            Num_grade2.Size = new Size(67, 23);
            Num_grade2.TabIndex = 56;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(387, 304);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(100, 23);
            txt_address.TabIndex = 53;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(387, 267);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MediumTurquoise;
            label9.Location = new Point(492, 304);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(101, 21);
            label9.TabIndex = 51;
            label9.Text = "Department ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumTurquoise;
            label5.Location = new Point(294, 306);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 47;
            label5.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(294, 348);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 46;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(293, 265);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 44;
            label1.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumTurquoise;
            label4.Location = new Point(399, 214);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 43;
            label4.Text = "Instructor Page";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(387, 348);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(100, 23);
            txt_email.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumTurquoise;
            label6.Location = new Point(522, 269);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 62;
            label6.Text = "Grade";
            label6.Click += label6_Click;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(387, 390);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(100, 23);
            txt_phone.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumTurquoise;
            label7.Location = new Point(294, 392);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 64;
            label7.Text = "Phone";
            label7.Click += label7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(294, 426);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 65;
            label2.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(387, 428);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(100, 23);
            txt_password.TabIndex = 66;
            // 
            // pic_image
            // 
            pic_image.Location = new Point(556, 377);
            pic_image.Name = "pic_image";
            pic_image.Size = new Size(100, 70);
            pic_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_image.TabIndex = 67;
            pic_image.TabStop = false;
            pic_image.Click += pic_image_Click;
            pic_image.Paint += pic_image_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MediumTurquoise;
            label8.Location = new Point(498, 394);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 68;
            label8.Text = "Image";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MediumTurquoise;
            label11.Location = new Point(500, 341);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(42, 21);
            label11.TabIndex = 69;
            label11.Text = "Role";
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(599, 343);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(57, 23);
            cb_role.TabIndex = 70;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 456);
            Controls.Add(cb_role);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(pic_image);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(txt_phone);
            Controls.Add(label6);
            Controls.Add(txt_email);
            Controls.Add(cb_dept);
            Controls.Add(Num_grade2);
            Controls.Add(txt_address);
            Controls.Add(txt_name);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(dgv_users);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            Load += AddUser_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgv_users;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button5;
        private Button button6;
        private ComboBox cb_dept;
        private NumericUpDown Num_grade2;
        private TextBox txt_address;
        private TextBox txt_name;
        private Label label9;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox txt_email;
        private Label label6;
        private TextBox txt_phone;
        private Label label7;
        private Label label2;
        private TextBox txt_password;
        private PictureBox pic_image;
        private Label label8;
        private Label label11;
        private ComboBox cb_role;
    }
}