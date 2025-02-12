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

            dgv_mycourses.DataSource = con.usercourses.Where(n => n.UserId == id).Select(n => new { n.course.Id, n.course.Name, n.course.StartDate, n.course.Description, n.course.EndDate, n.course.Hours, n.course.Degree, n.course.MinDegree }).ToList();
            dgv_mycourses.Columns["Id"].Visible = false;
         
        }

        private void btn_Favorite_Click(object sender, EventArgs e)
        {
            if (dgv_courses.SelectedRows.Count > 0)
            {
                int courseId = Convert.ToInt32(dgv_courses.SelectedRows[0].Cells["Id"].Value);
                int userId = id;

                var existing = con.usercourses.FirstOrDefault(uc => uc.UserId == userId && uc.CourseId == courseId);

                if (existing == null)
                {
                    var userCourse = new UserCourse
                    {
                        UserId = userId,
                        CourseId = courseId,
                        Status = "Enrolled"
                    };

                    con.usercourses.Add(userCourse);
                    con.SaveChanges();


                    dgv_mycourses.DataSource = con.usercourses
                        .Where(n => n.UserId == userId)
                        .Select(n => new
                        {
                            n.course.Name,
                            n.course.StartDate,
                            n.course.Description,
                            n.course.EndDate,
                            n.course.Hours,
                            n.course.Degree,
                            n.course.MinDegree
                        }).ToList();
                    MessageBox.Show("Course has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("You are already registered for this course!", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a course first!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgv_courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int courseId;
        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            courseId = (int)dgv_courses.SelectedRows[0].Cells["Id"].Value;
            if (courseId > 0)
            {
                Course cours = con.Courses.Where(n => n.Id == courseId).FirstOrDefault();
                if (cours != null)
                {
                    txt_name.Text = cours.Name;
                    txt_desc.Text = cours.Description;
                    Num_grade.Value = (int)cours.Degree;
                    Num_grade1.Value = (int)cours.MinDegree;
                    Num_grade2.Value = (int)cours.Hours;
                    date1.Value = (DateTime)cours.StartDate;
                    date2.Value = (DateTime)cours.EndDate;

                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dgv_mycourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_mycourses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            courseId = (int)dgv_mycourses.SelectedRows[0].Cells["Id"].Value;
            if (courseId > 0)
            {
                Course cours = con.Courses.Where(n => n.Id == courseId).FirstOrDefault();
                if (cours != null)
                {
                    txt_name.Text = cours.Name;
                    txt_desc.Text = cours.Description;
                    Num_grade.Value = (int)cours.Degree;
                    Num_grade1.Value = (int)cours.MinDegree;
                    Num_grade2.Value = (int)cours.Hours;
                    date1.Value = (DateTime)cours.StartDate;
                    date2.Value = (DateTime)cours.EndDate;

                }
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btn_removecourse_Click(object sender, EventArgs e)
        {
            //if (dgv_mycourses.SelectedRows.Count > 0) // التأكد من تحديد صف
            //{
            //    int courseId = Convert.ToInt32(dgv_mycourses.SelectedRows[0].Cells["Id"].Value);
            //    int userId = id; // نفترض أن id هو رقم المستخدم الحالي

            //    var userCourse = con.usercourses.FirstOrDefault(uc => uc.UserId == userId && uc.CourseId == courseId);

            //    if (userCourse != null)
            //    {
            //        con.usercourses.Remove(userCourse);
            //        con.SaveChanges();

            //        // تحديث dgv_mycourses بعد الحذف
            //        dgv_mycourses.DataSource = con.usercourses
            //            .Where(n => n.UserId == userId)
            //            .Select(n => new
            //            {
            //                n.course.Id, // لازم نجيب Id عشان نحذفه في المرات الجاية
            //                n.course.Name,
            //                n.course.StartDate,
            //                n.course.Description,
            //                n.course.EndDate,
            //                n.course.Hours,
            //                n.course.Degree,
            //                n.course.MinDegree
            //            }).ToList();
            //    }
            //    else
            //    {
            //        MessageBox.Show("هذا الكورس غير موجود في قائمتك!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("يرجى تحديد كورس لحذفه!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}


            if (dgv_mycourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to delete!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int courseId;
            if (!int.TryParse(dgv_mycourses.SelectedRows[0].Cells["Id"].Value?.ToString(), out courseId))
            {
                MessageBox.Show("Error fetching course data!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userCourse = con.usercourses.FirstOrDefault(uc => uc.UserId == id && uc.CourseId == courseId);

            if (userCourse != null)
            {
                con.usercourses.Remove(userCourse);
                con.SaveChanges();
                MessageBox.Show("The course has been successfully deleted!", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_mycourses.DataSource = con.usercourses
                    .Where(n => n.UserId == id)
                    .Select(n => new
                    {
                        n.course.Id,
                        n.course.Name,
                        n.course.StartDate,
                        n.course.Description,
                        n.course.EndDate,
                        n.course.Hours,
                        n.course.Degree,
                        n.course.MinDegree
                    }).ToList();
            }
            else
            {
                MessageBox.Show("This course is not on your list!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
