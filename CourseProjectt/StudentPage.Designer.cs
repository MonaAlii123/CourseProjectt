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
            button1 = new Button();
            dgv_mycourses = new DataGridView();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            dgv_courses = new DataGridView();
            btn_Favorite = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_mycourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dgv_mycourses);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 457);
            panel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(3, 14, 28);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(56, 222);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(131, 28);
            button1.TabIndex = 27;
            button1.Text = "My Courses";
            button1.UseVisualStyleBackColor = false;
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
            // btn_Favorite
            // 
            btn_Favorite.BackColor = Color.FromArgb(3, 14, 28);
            btn_Favorite.FlatAppearance.BorderSize = 0;
            btn_Favorite.FlatStyle = FlatStyle.Flat;
            btn_Favorite.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Favorite.ForeColor = Color.White;
            btn_Favorite.Location = new Point(382, 365);
            btn_Favorite.Margin = new Padding(2);
            btn_Favorite.Name = "btn_Favorite";
            btn_Favorite.Size = new Size(135, 28);
            btn_Favorite.TabIndex = 19;
            btn_Favorite.Text = "Add To MyCourses";
            btn_Favorite.UseVisualStyleBackColor = false;
            btn_Favorite.Click += btn_Favorite_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(3, 14, 28);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(359, 406);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(189, 28);
            button2.TabIndex = 26;
            button2.Text = " Remove from MyCourses";
            button2.UseVisualStyleBackColor = false;
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
            button3.Location = new Point(382, 320);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(135, 28);
            button3.TabIndex = 28;
            button3.Text = "Showprofile";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // StudentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 456);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btn_Favorite);
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
        private Button btn_Favorite;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button3;
    }
}