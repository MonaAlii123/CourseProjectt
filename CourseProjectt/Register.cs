using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProjectt.Models;

namespace CourseProjectt
{
    public partial class Register : Form
    {
        StudentContextt context = new StudentContextt();
        public Register()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txt_regusername.Text) ||
       string.IsNullOrEmpty(txt_regaddress.Text) ||
       string.IsNullOrEmpty(txt_regemail.Text) ||
       string.IsNullOrEmpty(txt_regphone.Text) ||
       string.IsNullOrEmpty(txt_Passowrd.Text) ||
       string.IsNullOrEmpty(txt_confpassword.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التحقق من صحة البريد الإلكتروني باستخدام Regex
            if (!Regex.IsMatch(txt_regemail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التحقق من كلمة المرور
            if (txt_Passowrd.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التحقق من تطابق كلمات المرور
            if (txt_Passowrd.Text != txt_confpassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التحقق من رقم الهاتف (يجب أن يكون 11 رقماً)
            if (!Regex.IsMatch(txt_regphone.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Phone number must contain exactly 11 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التأكد من عدم تكرار البريد الإلكتروني في قاعدة البيانات
            var existingUser = context.users.FirstOrDefault(x => x.Email == txt_regemail.Text);
            if (existingUser != null)
            {
                MessageBox.Show("An account with this email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // إنشاء المستخدم الجديد
            User user = new User
            {
                Image = pic_image.Tag != null ? Path.GetFileName(pic_image.Tag.ToString()) : "default.png",
                Name = txt_regusername.Text,
                Address = txt_regaddress.Text,
                Grade = (int)Num_grade.Value,
                Email = txt_regemail.Text,
                phone = txt_regphone.Text,
                Password = txt_Passowrd.Text,
                Role = "student"
            };

            // حفظ المستخدم في قاعدة البيانات
            context.Add(user);
            context.SaveChanges();

            // رسالة نجاح
            MessageBox.Show("Welcome! Your account has been created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // فتح شاشة تسجيل الدخول
            Login login = new Login();
            login.ShowDialog();
            this.Hide();

            //if (string.IsNullOrEmpty(txt_regusername.Text) ||
            //    string.IsNullOrEmpty(txt_regaddress.Text) ||
            //    string.IsNullOrEmpty(txt_regemail.Text) ||
            //    string.IsNullOrEmpty(txt_regphone.Text) ||
            //    string.IsNullOrEmpty(txt_Passowrd.Text))
            //{
            //    MessageBox.Show("Please fill all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (!txt_regemail.Text.Contains("@") || !txt_regemail.Text.Contains("."))
            //{
            //    MessageBox.Show("Please write the email correctly ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (txt_Passowrd.Text.Length < 6)
            //{
            //    MessageBox.Show("Password must be at least 6 characters!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (txt_regphone.Text.Length != 11)

            //{
            //    MessageBox.Show("Phone must be at 11 numbers!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (string.IsNullOrEmpty(txt_Passowrd.Text) || string.IsNullOrEmpty(txt_confpassword.Text))
            //{
            //    MessageBox.Show("Please fill in both fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else if (txt_Passowrd.Text != txt_confpassword.Text)
            //{
            //    MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    MessageBox.Show("Password confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}


            //User user = new User();
            //user.Image = Path.GetFileName(pic_image.Tag?.ToString());
            //user.Name = txt_regusername.Text;
            //user.Address = txt_regaddress.Text;
            //user.Grade = (int)Num_grade.Value;
            //user.Email = txt_regemail.Text;
            //user.phone = txt_regphone.Text;
            //user.Password = txt_Passowrd.Text;
            //user.Role = "student";
            //var q1 = context.users.Where(x => x.Email == user.Email).SingleOrDefault();
            //if (q1 != null)
            //{
            //    MessageBox.Show("already have an account", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //context.Add(user);
            //context.SaveChanges();
            //MessageBox.Show("Welcome to our page ,you are logged sucessfully");
            //Login login = new Login();
            //login.ShowDialog();
            //this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Passowrd.PasswordChar = register_showPass.Checked ? '\0' : '*';
            txt_confpassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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
    }
}
