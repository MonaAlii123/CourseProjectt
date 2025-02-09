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

namespace CourseProjectt
{

    public partial class StudentPage : Form
    {
        int id;
        StudentContextt con;
        public StudentPage(int id)
        {
            this.id = id;
            InitializeComponent();
            con = new StudentContextt();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowProfile pro = new ShowProfile(id);
            pro.ShowDialog();
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {

            dgv_courses.DataSource = con.Courses.Select(n => new { n.Id, n.Name, n.Description, n.Degree, n.MinDegree, n.Hours, n.StartDate, n.EndDate, n.DepartmentId }).ToList();
            dgv_courses.Columns["Id"].Visible = false;
        }

        private void btn_Favorite_Click(object sender, EventArgs e)
        {

        }

        private void dgv_courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int courseId;
        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //courseId = (int)dgv_courses.SelectedRows[0].Cells["Id"].Value;
            //if (courseId > 0)
            //{
            //    Course cours = con.Courses.Where(n => n.Id == courseId).FirstOrDefault();
            //    if (cours != null)
            //    {
            //        txt_deptname.Text = dept.Name;
            //        txt_mangername.Text = dept.ManagerName;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}
        }
    }
}
