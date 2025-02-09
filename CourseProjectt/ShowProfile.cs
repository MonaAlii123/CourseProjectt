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
using CourseProjectt.Models;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CourseProjectt
{
    public partial class ShowProfile : Form
    {
        int id;
        StudentContextt context;
        SqlConnection con;

        public ShowProfile()
        {
            InitializeComponent();
            context = new StudentContextt();
            con = new SqlConnection("Server=DESKTOP-FRBH0T7\\SQLEXPRESS;Database=CourseDB;Trusted_Connection=True; TrustServerCertificate=True");
        }
        public ShowProfile(int id)
        {
            InitializeComponent();
            this.id = id;
            context = new StudentContextt();
            con = new SqlConnection("Server=DESKTOP-FRBH0T7\\SQLEXPRESS;Database=CourseDB;Trusted_Connection=True; TrustServerCertificate=True");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditProfile profile = new EditProfile(id);
            profile.ShowDialog();
        }

        private void ShowProfile_Load(object sender, EventArgs e)
        {
            var data = context.users.Where(s => s.Id == id).SingleOrDefault();
            if (data == null)
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            label9.Text = data.Name;
            label10.Text = data.Address ?? "N/A";
            label11.Text = data.Grade?.ToString() ?? "N/A";
            label12.Text = data.phone ?? "N/A";
            label13.Text = data.Email ?? "N/A";
            label14.Text = data.Password ?? "N/A";

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pic_image_Click(object sender, EventArgs e)
        {

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

                // رسم حدود للصورة
                using (Pen pen = new Pen(Color.Black, 5)) // تعديل لون وسمك الحدود هنا
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawEllipse(pen, 0, 0, pic_image.Width - 1, pic_image.Height - 1);
                }
            }
        }
    }

}
        
    

