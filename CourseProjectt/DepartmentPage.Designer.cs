namespace CourseProjectt
{
    partial class DepartmentPage
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
            button7 = new Button();
            button6 = new Button();
            label4 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            dgv_dept = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txt_deptname = new TextBox();
            txt_mangername = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_dept).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 457);
            panel1.TabIndex = 3;
            // 
            // button7
            // 
            button7.BackColor = Color.MediumTurquoise;
            button7.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(21, 213);
            button7.Name = "button7";
            button7.Size = new Size(109, 35);
            button7.TabIndex = 27;
            button7.Text = "Users";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumTurquoise;
            button6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(21, 266);
            button6.Name = "button6";
            button6.Size = new Size(109, 35);
            button6.TabIndex = 26;
            button6.Text = "Department";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(3, 14, 28);
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumTurquoise;
            label4.Location = new Point(21, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 25;
            label4.Text = "Department";
            // 
            // button5
            // 
            button5.BackColor = Color.MediumTurquoise;
            button5.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(21, 378);
            button5.Name = "button5";
            button5.Size = new Size(109, 35);
            button5.TabIndex = 10;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumTurquoise;
            button4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(21, 322);
            button4.Name = "button4";
            button4.Size = new Size(109, 35);
            button4.TabIndex = 9;
            button4.Text = "Course";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(30, 319);
            button3.Name = "button3";
            button3.Size = new Size(100, 35);
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
            button2.Location = new Point(30, 260);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
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
            button1.Location = new Point(30, 201);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(175, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 432);
            panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image1;
            pictureBox2.Location = new Point(39, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dgv_dept
            // 
            dgv_dept.AllowUserToOrderColumns = true;
            dgv_dept.BackgroundColor = Color.White;
            dgv_dept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dept.Location = new Point(358, 12);
            dgv_dept.Name = "dgv_dept";
            dgv_dept.Size = new Size(297, 176);
            dgv_dept.TabIndex = 26;
            dgv_dept.CellContentClick += dgv_dept_CellContentClick_1;
            dgv_dept.RowHeaderMouseDoubleClick += dgv_dept_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(358, 213);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 27;
            label1.Text = "Department Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(358, 272);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 28;
            label2.Text = "Manager Name";
            // 
            // txt_deptname
            // 
            txt_deptname.Location = new Point(507, 215);
            txt_deptname.Name = "txt_deptname";
            txt_deptname.Size = new Size(148, 23);
            txt_deptname.TabIndex = 34;
            // 
            // txt_mangername
            // 
            txt_mangername.Location = new Point(507, 270);
            txt_mangername.Name = "txt_mangername";
            txt_mangername.Size = new Size(148, 23);
            txt_mangername.TabIndex = 35;
            // 
            // DepartmentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 456);
            Controls.Add(txt_mangername);
            Controls.Add(txt_deptname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_dept);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DepartmentPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepartmentPage";
            Load += DepartmentPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_dept).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button button5;
        private Label label4;
        private DataGridView dgv_dept;
        private Label label1;
        private Label label2;
        private TextBox txt_deptname;
        private TextBox txt_mangername;
        private Button button7;
        private Button button6;
    }
}