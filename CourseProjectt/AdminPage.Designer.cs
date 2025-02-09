namespace CourseProjectt
{
    partial class AdminPage
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dgv_courses = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_name = new TextBox();
            txt_desc = new TextBox();
            Num_grade = new NumericUpDown();
            Num_grade1 = new NumericUpDown();
            Num_grade2 = new NumericUpDown();
            date1 = new DateTimePicker();
            date2 = new DateTimePicker();
            label10 = new Label();
            cb_dept = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 457);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumTurquoise;
            button5.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(42, 388);
            button5.Name = "button5";
            button5.Size = new Size(134, 35);
            button5.TabIndex = 10;
            button5.Text = "Show Profile";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumTurquoise;
            button4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(42, 333);
            button4.Name = "button4";
            button4.Size = new Size(134, 35);
            button4.TabIndex = 9;
            button4.Text = "Depaertment";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(42, 280);
            button3.Name = "button3";
            button3.Size = new Size(134, 35);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(42, 225);
            button2.Name = "button2";
            button2.Size = new Size(134, 35);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(42, 168);
            button1.Name = "button1";
            button1.Size = new Size(134, 35);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image1;
            pictureBox1.Location = new Point(58, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgv_courses
            // 
            dgv_courses.AllowUserToOrderColumns = true;
            dgv_courses.BackgroundColor = Color.White;
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(233, 269);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.Size = new Size(422, 175);
            dgv_courses.TabIndex = 3;
            dgv_courses.CellContentClick += dgv_courses_CellContentClick;
            dgv_courses.RowHeaderMouseDoubleClick += dgv_courses_RowHeaderMouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumTurquoise;
            label4.Location = new Point(356, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 24;
            label4.Text = "Instructor Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(245, 61);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 25;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(245, 192);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 26;
            label2.Text = "Min Degree";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(245, 146);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 27;
            label3.Text = "Degree";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumTurquoise;
            label5.Location = new Point(245, 100);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 28;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumTurquoise;
            label6.Location = new Point(474, 100);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 29;
            label6.Text = "Start Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumTurquoise;
            label7.Location = new Point(474, 61);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 21);
            label7.TabIndex = 30;
            label7.Text = "Hours";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MediumTurquoise;
            label8.Location = new Point(474, 146);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 31;
            label8.Text = "End Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MediumTurquoise;
            label9.Location = new Point(474, 192);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(101, 21);
            label9.TabIndex = 32;
            label9.Text = "Department ";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(356, 61);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 33;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(356, 102);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(100, 23);
            txt_desc.TabIndex = 34;
            // 
            // Num_grade
            // 
            Num_grade.Location = new Point(356, 146);
            Num_grade.Margin = new Padding(2);
            Num_grade.Name = "Num_grade";
            Num_grade.Size = new Size(67, 23);
            Num_grade.TabIndex = 36;
            Num_grade.ValueChanged += Num_grade_ValueChanged;
            // 
            // Num_grade1
            // 
            Num_grade1.Location = new Point(356, 195);
            Num_grade1.Margin = new Padding(2);
            Num_grade1.Name = "Num_grade1";
            Num_grade1.Size = new Size(67, 23);
            Num_grade1.TabIndex = 37;
            // 
            // Num_grade2
            // 
            Num_grade2.Location = new Point(568, 59);
            Num_grade2.Margin = new Padding(2);
            Num_grade2.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            Num_grade2.Name = "Num_grade2";
            Num_grade2.Size = new Size(67, 23);
            Num_grade2.TabIndex = 38;
            // 
            // date1
            // 
            date1.Location = new Point(568, 98);
            date1.Name = "date1";
            date1.Size = new Size(89, 23);
            date1.TabIndex = 39;
            // 
            // date2
            // 
            date2.Location = new Point(568, 142);
            date2.Name = "date2";
            date2.Size = new Size(89, 23);
            date2.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(637, 8);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(20, 21);
            label10.TabIndex = 41;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(568, 194);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(89, 23);
            cb_dept.TabIndex = 42;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 456);
            Controls.Add(cb_dept);
            Controls.Add(label10);
            Controls.Add(date2);
            Controls.Add(date1);
            Controls.Add(Num_grade2);
            Controls.Add(Num_grade1);
            Controls.Add(Num_grade);
            Controls.Add(txt_desc);
            Controls.Add(txt_name);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(dgv_courses);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPage";
            Load += AdminPage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_grade2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dgv_courses;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_name;
        private TextBox txt_desc;
        private NumericUpDown Num_grade;
        private NumericUpDown Num_grade1;
        private NumericUpDown Num_grade2;
        private DateTimePicker date1;
        private DateTimePicker date2;
        private Label label10;
        private Button button5;
        private ComboBox cb_dept;
    }
}