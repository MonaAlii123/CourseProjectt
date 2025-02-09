using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CourseProjectt.Models;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CourseProjectt
{
    public partial class EditProfile : Form
    {
        int id;
        StudentContextt context;
        public EditProfile()
        {
            InitializeComponent();
            context = new StudentContextt();
        }
        public EditProfile(int id)
        {
            InitializeComponent();
            this.id = id;
            context = new StudentContextt();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            ShowProfile profile = new ShowProfile(id);
            profile.ShowDialog();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            var data = context.users.SingleOrDefault(s => s.Id == id);



            if (data != null)
            {

                if (!string.IsNullOrEmpty(data.Image))
                {
                    string imagePath = Path.Combine(@"C:\Images", data.Image);

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

                txt_confpassword.Text = data.Password;
                txt_password.Text = data.Password;
                txt_regaddress.Text = data.Address;
                txt_email.Text = data.Email;
                txt_regphone.Text = data.phone;
                txt_regusername.Text = data.Name;
                Num_grade.Value = (int)data.Grade;

            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = showpass.Checked ? '\0' : '*';
            txt_confpassword.PasswordChar = showpass.Checked ? '\0' : '*';
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

        private void button1_Click_1(object sender, EventArgs e)
        {

            var user = context.users.SingleOrDefault(s => s.Id == id);

            if (user != null)
            {
                if (!txt_email.Text.Contains("@") || !txt_email.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_confpassword.Text))
                {
                    MessageBox.Show("Please fill in both password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_password.Text != txt_confpassword.Text)
                {
                    MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                user.Image = Path.GetFileName(pic_image.Tag?.ToString());
                user.Password = txt_password.Text;
                user.Email = txt_email.Text;
                user.Address = txt_regaddress.Text;
                user.phone = txt_regphone.Text;
                user.Name = txt_regusername.Text;
                user.Grade = (int)Num_grade.Value;


                context.SaveChanges();

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var data = context.users.Where(s => s.Id == id).SingleOrDefault();
            if (data.Role == "student")
            {

                StudentPage page = new StudentPage(id);
                page.ShowDialog();
                this.Hide();
            }
            else if (data.Role == "instructor")
            {

                AdminPage page = new AdminPage(id);
                page.ShowDialog();
                this.Hide();
            }

        }

        private void pic_image_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, pic_image.Width, pic_image.Height);
                pic_image.Region = new Region(path);

               
                using (Pen pen = new Pen(Color.Blue, 5)) 
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawEllipse(pen, 0, 0, pic_image.Width - 1, pic_image.Height - 1);
                }
            }
        }
    }
}

