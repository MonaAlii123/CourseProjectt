using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProjectt.Models;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CourseProjectt
{
    public partial class AdminPage : Form
    {
        int id;
        StudentContextt con;
        public AdminPage()
        {
            InitializeComponent();
            con = new StudentContextt();
        }

        public AdminPage(int id)
        {
            InitializeComponent();
            this.id = id;
            con = new StudentContextt();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            var data = con.users.Where(s => s.Id == id).SingleOrDefault();


            dgv_courses.DataSource = con.Courses.Select(n => new { n.Id, n.Name, n.Description, n.Degree, n.MinDegree, n.Hours, n.StartDate, n.EndDate, n.DepartmentId }).ToList();
            cb_dept.DataSource = con.Departments.Select(n => n).ToList();
            cb_dept.ValueMember = "Id";
            cb_dept.DisplayMember = "Name";
            dgv_courses.Columns["id"].Visible = false;
            dgv_courses.Columns["DepartmentId"].Visible = false;


        }
        int courseId;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(txt_name.Text == " " && txt_desc.Text == " "))
            {
                bool isExist = con.Courses.Any(d => d.Name == txt_name.Text);
                if (isExist)
                {
                    MessageBox.Show("This Course already exit!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Course course = new Course()
                    {
                        Name = txt_name.Text,
                        Description = txt_desc.Text,
                        Degree = (int)Num_grade.Value,
                        MinDegree = (int)Num_grade1.Value,
                        Hours = (int)Num_grade2.Value,
                        StartDate = date1.Value,
                        EndDate = date2.Value,
                        DepartmentId = (int)cb_dept.SelectedValue,
                    };

                    con.Courses.Add(course);
                    con.SaveChanges();
                    dgv_courses.DataSource = con.Courses.Select(n => new { n.Id, n.Name, n.Description, n.Degree, n.MinDegree, n.Hours, n.StartDate, n.EndDate, n.DepartmentId }).ToList();
                    dgv_courses.Columns["Id"].Visible = false;
                    dgv_courses.Columns["DepartmentId"].Visible = false;


                    MessageBox.Show("SuccessFully Added");
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Data");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DepartmentPage dept = new DepartmentPage();
            dept.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowProfile pro = new ShowProfile(id);
            pro.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course n = con.Courses.Where(n => n.Id == courseId).FirstOrDefault();
            if (n != null)
            {
                con.Remove(n);
                con.SaveChanges();

                dgv_courses.DataSource = con.Courses.Select(n => new { n.Id, n.Name, n.Description, n.Degree, n.MinDegree, n.Hours, n.StartDate, n.EndDate, n.DepartmentId }).ToList();
                dgv_courses.Columns["Id"].Visible = false;
                dgv_courses.Columns["DepartmentId"].Visible = false;


                MessageBox.Show("SuccessFully deleted");

            }
            else { MessageBox.Show("Error"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course s = con.Courses.Where(n => n.Id == courseId).FirstOrDefault();
            if (!(txt_name.Text == " " && txt_desc.Text == " "))
            {
                s.Name = txt_name.Text;
                s.Description = txt_desc.Text;
                s.Degree = (int)Num_grade.Value;
                s.MinDegree = (int)Num_grade1.Value;
                s.Hours = (int)Num_grade2.Value;
                s.StartDate = date1.Value;
                s.EndDate = date2.Value;
                s.DepartmentId = (int)cb_dept.SelectedValue;
                con.SaveChanges();



                dgv_courses.DataSource = con.Courses.Select(n => new { n.Id, n.Name, n.Description, n.Degree, n.MinDegree, n.Hours, n.StartDate, n.EndDate, n.DepartmentId }).ToList();
                dgv_courses.Columns["Id"].Visible = false;
                dgv_courses.Columns["DepartmentId"].Visible = false;



                MessageBox.Show("SuccessFully Updated");
            }
            else
            {
                MessageBox.Show("Enter Data As Successfull");
            }
        }

        private void Num_grade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            courseId = (int)dgv_courses.SelectedRows[0].Cells["Id"].Value;
            if (courseId > 0)
            {
                Course course = con.Courses.Where(n => n.Id == courseId).FirstOrDefault();
                if (course != null)
                {
                    txt_name.Text = course.Name;
                    txt_desc.Text = course.Description;
                    Num_grade.Value = (int)course.Degree;
                    Num_grade1.Value = (int)course.MinDegree;
                    Num_grade2.Value =  (int)course.Hours;
                    date1.Value=(DateTime)course.StartDate;
                    date2.Value=(DateTime)course.EndDate;
                    cb_dept.SelectedValue = course.DepartmentId;
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dgv_courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
