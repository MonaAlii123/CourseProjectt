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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CourseProjectt
{
    public partial class DepartmentPage : Form
    {
        StudentContextt con;
        int id;
        public DepartmentPage()
        {
            InitializeComponent();
            con = new StudentContextt();
        }
        public DepartmentPage(int id )
        {
            this.id = id;
            InitializeComponent();
            con = new StudentContextt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_deptname.Text) && !string.IsNullOrWhiteSpace(txt_mangername.Text))
            {

                bool isExist = con.Departments.Any(d => d.Name == txt_deptname.Text);

                if (isExist)
                {
                    MessageBox.Show("This Department already exit!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Department dept = new Department()
                    {
                        Name = txt_deptname.Text,
                        ManagerName = txt_mangername.Text
                    };

                    con.Departments.Add(dept);
                    con.SaveChanges();
                    dgv_dept.DataSource = con.Departments.Select(n => new { n.Id, n.Name, n.ManagerName }).ToList();
                    dgv_dept.Columns["Id"].Visible = false;
                    MessageBox.Show("SuccessFully Added", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Data", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int deptId;
        private void DepartmentPage_Load(object sender, EventArgs e)
        {
            dgv_dept.DataSource = con.Departments.Select(n => new { n.Id, n.Name, n.ManagerName }).ToList();
            dgv_dept.Columns["Id"].Visible = false;
        }

        private void dgv_dept_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deptId = (int)dgv_dept.SelectedRows[0].Cells["Id"].Value;
            if (deptId > 0)
            {
                Department dept = con.Departments.Where(n => n.Id == deptId).FirstOrDefault();
                if (dept != null)
                {
                    txt_deptname.Text = dept.Name;
                    txt_mangername.Text = dept.ManagerName;
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Department s = con.Departments.Where(n => n.Id == deptId).FirstOrDefault();
            if (!(txt_deptname.Text == " " && txt_mangername.Text == " "))
            {
                s.Name = txt_deptname.Text;
                s.ManagerName = txt_mangername.Text;
                con.SaveChanges();



                dgv_dept.DataSource = con.Departments.Select(n => new { n.Id, n.Name, n.ManagerName }).ToList();
                dgv_dept.Columns["Id"].Visible = false;
                MessageBox.Show("SuccessFully Updated");
            }
            else
            {
                MessageBox.Show("Enter Data As Successfull");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Department n = con.Departments.Where(n => n.Id == deptId).FirstOrDefault();
            if (n != null)
            {
                con.Remove(n);
                con.SaveChanges();

                dgv_dept.DataSource = con.Departments.Select(n => new { n.Id, n.Name, n.ManagerName }).ToList();
                dgv_dept.Columns["Id"].Visible = false;
                MessageBox.Show("SuccessFully deleted");
            }
            else { MessageBox.Show("Error"); }
        }

        private void dgv_dept_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            deptId = (int)dgv_dept.SelectedRows[0].Cells["Id"].Value;
            if (deptId > 0)
            {
                Department dept = con.Departments.Where(n => n.Id == deptId).FirstOrDefault();
                if (dept != null)
                {
                    txt_deptname.Text = dept.Name;
                    txt_mangername.Text = dept.ManagerName;
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(id);
            addUser.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dgv_dept_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
