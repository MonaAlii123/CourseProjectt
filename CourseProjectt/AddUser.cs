using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProjectt.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CourseProjectt
{
    public partial class AddUser : Form
    {
        int id;
        StudentContextt con;
        public AddUser()
        {
            InitializeComponent();
            con = new StudentContextt();
        }
        public AddUser(int id)
        {
            InitializeComponent();
            this.id = id;
            con = new StudentContextt();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = con.users.Select(n => new { n.Id, n.Name, n.Image, n.Address, n.Email, n.Password, n.phone, n.Grade, n.Role, n.DepartmentId }).ToList();
            cb_dept.DataSource = con.Departments.Select(n => n).ToList();
            cb_dept.ValueMember = "Id";
            cb_dept.DisplayMember = "Name";
            cb_role.DataSource = con.users.Select(u => u.Role).Distinct().ToList();
            // cb_role.ValueMember = "Id";
            cb_role.DisplayMember = "Role";
            dgv_users.Columns["id"].Visible = false;
            dgv_users.Columns["DepartmentId"].Visible = false;
            dgv_users.Columns["password"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DepartmentPage departmentPage = new DepartmentPage();
            departmentPage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int userId;
        private void button6_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_address.Text) || string.IsNullOrWhiteSpace(txt_phone.Text) || string.IsNullOrWhiteSpace(txt_password.Text)))
            {

                bool isExist = con.users.Any(d => d.Name == txt_name.Text);
                if (isExist)
                {
                    MessageBox.Show("This user already exit!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                    if (!Regex.IsMatch(txt_email.Text, emailPattern))
                    {
                        MessageBox.Show(" Please enter a valid email address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_phone.Text.Length != 11)

                    {
                        MessageBox.Show("Phone must be at 11 numbers!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    User user = new User()
                    {
                        Image = Path.GetFileName(pic_image.Tag?.ToString()),
                        Name = txt_name.Text,
                        Email = txt_email.Text,
                        Address = txt_address.Text,
                        Password = txt_password.Text,
                        phone = txt_phone.Text,
                        Grade = (int)Num_grade2.Value,
                        Role = cb_role.SelectedValue.ToString(),
                        DepartmentId = (int)cb_dept.SelectedValue,
                    };

                    con.users.Add(user);
                    con.SaveChanges();
                    dgv_users.DataSource = con.users.Select(n => new { n.Id, n.Name, n.Image, n.Address, n.Email, n.Password, n.phone, n.Grade, n.Role, n.DepartmentId }).ToList();
                    dgv_users.Columns["Id"].Visible = false;
                    dgv_users.Columns["DepartmentId"].Visible = false;
                    dgv_users.Columns["password"].Visible = false;

                    MessageBox.Show("SuccessFully Added");
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Data");
            }
        }

        private void pic_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_image.Image = Image.FromFile(openFileDialog.FileName);
                pic_image.Tag = openFileDialog.FileName;
            }
        }

        private void dgv_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userId = (int)dgv_users.SelectedRows[0].Cells["Id"].Value;
            if (userId > 0)
            {
                User user = con.users.Where(n => n.Id == userId).FirstOrDefault();
                if (user != null)
                {
                    txt_name.Text = user.Name;
                    txt_email.Text = user.Email;
                    txt_password.Text = user.Password;
                    txt_address.Text = user.Address;
                    txt_phone.Text = user.phone;
                 //  cb_role.SelectedValue = user.Id ;
                    cb_dept.SelectedValue = user.DepartmentId ;


                    Num_grade2.Value = (int)user.Grade;
                    if (!string.IsNullOrEmpty(user.Image))
                    {
                        string imagePath = Path.Combine(@"C:\Images", user.Image);

                        if (File.Exists(imagePath))
                        {
                            pic_image.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            pic_image.Image = Properties.Resources.mona;
                        }
                    }
                    else
                    {
                        pic_image.Image = Properties.Resources.mona;
                    }




                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            User s = con.users.Where(n => n.Id == userId).FirstOrDefault();
            if (!(string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_address.Text) || string.IsNullOrWhiteSpace(txt_phone.Text) || string.IsNullOrWhiteSpace(txt_password.Text)))
            {
                s.Name = txt_name.Text;
                s.Image = Path.GetFileName(pic_image.Tag?.ToString());
                s.Email = txt_email.Text;
                s.Address = txt_address.Text;
                s.Password = txt_password.Text;
                s.phone = txt_phone.Text;
                s.Grade = (int)Num_grade2.Value;
                s.Role = cb_role.SelectedValue.ToString();
                s.DepartmentId = (int)cb_dept.SelectedValue;
                con.SaveChanges();

                dgv_users.DataSource = con.users.Select(n => new { n.Id, n.Name, n.Image, n.Address, n.Email, n.Password, n.phone, n.Grade, n.Role, n.DepartmentId }).ToList();
                dgv_users.Columns["Id"].Visible = false;
                dgv_users.Columns["DepartmentId"].Visible = false;
                dgv_users.Columns["Password"].Visible = false;


                MessageBox.Show("SuccessFully Updated");
            }
            else
            {
                MessageBox.Show("Enter Data As Successfull");
            }
        }

        private void pic_image_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, pic_image.Width, pic_image.Height);
                pic_image.Region = new Region(path);


                using (Pen pen = new Pen(Color.Black, 5))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawEllipse(pen, 0, 0, pic_image.Width - 1, pic_image.Height - 1);
                }
            }
        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
