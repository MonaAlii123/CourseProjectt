namespace CourseProjectt
{
    partial class StudentPage
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
            label7 = new Label();
            panel1 = new Panel();
            btn_mycourses = new Button();
            dgv_mycourses = new DataGridView();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            dgv_courses = new DataGridView();
            btn_addcourse = new Button();
            btn_removecourse = new Button();
            label1 = new Label();
            button3 = new Button();
            date2 = new DateTimePicker();
            date1 = new DateTimePicker();
            Num_grade2 = new NumericUpDown();
            Num_grade1 = new NumericUpDown();
            Num_grade = new NumericUpDown();
            txt_desc = new TextBox();
            txt_name = new TextBox();
            label8 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_mycourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumTurquoise;
            label7.Location = new Point(400, 9);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 32);
            label7.TabIndex = 16;
            label7.Text = " Courses";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_mycourses);
            panel1.Controls.Add(dgv_mycourses);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 457);
            panel1.TabIndex = 17;
            // 
            // btn_mycourses
            // 
            btn_mycourses.BackColor = Color.FromArgb(3, 14, 28);
            btn_mycourses.FlatAppearance.BorderSize = 0;
            btn_mycourses.FlatStyle = FlatStyle.Flat;
            btn_mycourses.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_mycourses.ForeColor = Color.White;
            btn_mycourses.Location = new Point(56, 222);
            btn_mycourses.Margin = new Padding(2);
            btn_mycourses.Name = "btn_mycourses";
            btn_mycourses.Size = new Size(131, 28);
            btn_mycourses.TabIndex = 27;
            btn_mycourses.Text = "My Courses";
            btn_mycourses.UseVisualStyleBackColor = false;
            // 
            // dgv_mycourses
            // 
            dgv_mycourses.AllowUserToOrderColumns = true;
            dgv_mycourses.BackgroundColor = Color.White;
            dgv_mycourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_mycourses.Location = new Point(3, 276);
            dgv_mycourses.Name = "dgv_mycourses";
            dgv_mycourses.Size = new Size(246, 178);
            dgv_mycourses.TabIndex = 19;
            dgv_mycourses.CellContentClick += dgv_mycourses_CellContentClick;
            dgv_mycourses.RowHeaderMouseDoubleClick += dgv_mycourses_RowHeaderMouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(56, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(3, 14, 28);
            label4.Location = new Point(67, 19);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 17;
            label4.Text = "My Courses";
            // 
            // dgv_courses
            // 
            dgv_courses.AllowUserToOrderColumns = true;
            dgv_courses.BackgroundColor = Color.White;
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(258, 44);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.Size = new Size(397, 216);
            dgv_courses.TabIndex = 18;
            dgv_courses.CellContentClick += dgv_courses_CellContentClick;
            dgv_courses.RowHeaderMouseDoubleClick += dgv_courses_RowHeaderMouseDoubleClick;
            // 
            // btn_addcourse
            // 
            btn_addcourse.BackColor = Color.FromArgb(3, 14, 28);
            btn_addcourse.FlatAppearance.BorderSize = 0;
            btn_addcourse.FlatStyle = FlatStyle.Flat;
            btn_addcourse.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addcourse.ForeColor = Color.White;
            btn_addcourse.Location = new Point(520, 417);
            btn_addcourse.Margin = new Padding(2);
            btn_addcourse.Name = "btn_addcourse";
            btn_addcourse.Size = new Size(135, 28);
            btn_addcourse.TabIndex = 19;
            btn_addcourse.Text = "Add To MyCourses";
            btn_addcourse.UseVisualStyleBackColor = false;
            btn_addcourse.Click += btn_Favorite_Click;
            // 
            // btn_removecourse
            // 
            btn_removecourse.BackColor = Color.FromArgb(3, 14, 28);
            btn_removecourse.FlatAppearance.BorderSize = 0;
            btn_removecourse.FlatStyle = FlatStyle.Flat;
            btn_removecourse.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_removecourse.ForeColor = Color.White;
            btn_removecourse.Location = new Point(393, 417);
            btn_removecourse.Margin = new Padding(2);
            btn_removecourse.Name = "btn_removecourse";
            btn_removecourse.Size = new Size(115, 28);
            btn_removecourse.TabIndex = 26;
            btn_removecourse.Text = " Remove from MyCourses";
            btn_removecourse.UseVisualStyleBackColor = false;
            btn_removecourse.Click += btn_removecourse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(626, 9);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 27;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(3, 14, 28);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(258, 417);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(115, 28);
            button3.TabIndex = 28;
            button3.Text = "Showprofile";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // date2
            // 
            date2.Location = new Point(577, 344);
            date2.Name = "date2";
            date2.Size = new Size(89, 23);
            date2.TabIndex = 57;
            // 
            // date1
            // 
            date1.Location = new Point(577, 300);
            date1.Name = "date1";
            date1.Size = new Size(89, 23);
            date1.TabIndex = 56;
            // 
            // Num_grade2
            // 
            Num_grade2.Location = new Point(577, 266);
            Num_grade2.Margin = new Padding(2);
            Num_grade2.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            Num_grade2.Name = "Num_grade2";
            Num_grade2.Size = new Size(67, 23);
            Num_grade2.TabIndex = 55;
            // 
            // Num_grade1
            // 
            Num_grade1.Location = new Point(365, 384);
            Num_grade1.Margin = new Padding(2);
            Num_grade1.Name = "Num_grade1";
            Num_grade1.Size = new Size(67, 23);
            Num_grade1.TabIndex = 54;
            // 
            // Num_grade
            // 
            Num_grade.Location = new Point(365, 344);
            Num_grade.Margin = new Padding(2);
            Num_grade.Name = "Num_grade";
            Num_grade.Size = new Size(67, 23);
            Num_grade.TabIndex = 53;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(365, 304);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(100, 23);
            txt_desc.TabIndex = 52;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(365, 266);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MediumTurquoise;
            label8.Location = new Point(483, 348);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 49;
            label8.Text = "End Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(483, 268);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 48;
            label2.Text = "Hours";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumTurquoise;
            label6.Location = new Point(483, 302);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 47;
            label6.Text = "Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumTurquoise;
            label5.Location = new Point(254, 302);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 46;
            label5.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(258, 344);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 45;
            label3.Text = "Degree";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MediumTurquoise;
            label10.Location = new Point(258, 384);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(93, 21);
            label10.TabIndex = 44;
            label10.Text = "Min Degree";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MediumTurquoise;
            label11.Location = new Point(254, 263);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(106, 21);
            label11.TabIndex = 43;
            label11.Text = "Course Name";
            // 
            // StudentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 456);
            Controls.Add(date2);
            Controls.Add(date1);
            Controls.Add(Num_grade2);
            Controls.Add(Num_grade1);
            Controls.Add(Num_grade);
            Controls.Add(txt_desc);
            Controls.Add(txt_name);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(btn_removecourse);
            Controls.Add(btn_addcourse);
            Controls.Add(dgv_courses);
            Controls.Add(panel1);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentPage";
            Load += StudentPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_mycourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel1;
        private DataGridView dgv_mycourses;
        private PictureBox pictureBox1;
        private Label label4;
        private DataGridView dgv_courses;
        private Button btn_addcourse;
        private Button btn_removecourse;
        private Button btn_mycourses;
        private Label label1;
        private Button button3;
        private DateTimePicker date2;
        private DateTimePicker date1;
        private NumericUpDown Num_grade2;
        private NumericUpDown Num_grade1;
        private NumericUpDown Num_grade;
        private TextBox txt_desc;
        private TextBox txt_name;
        private Label label8;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label10;
        private Label label11;
    }
}