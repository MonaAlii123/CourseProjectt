using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProjectt.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CourseProjectt
{
    public partial class Login : Form
    {
        int id;
        SqlConnection con;
        StudentContextt contextt;
        public Login()
        {
            contextt = new StudentContextt();
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-FRBH0T7\\SQLEXPRESS;Database=CourseDB;Trusted_Connection=True; TrustServerCertificate=True");
        }
        public Login(int id)
        {
            this.id = id;
            contextt = new StudentContextt();
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-FRBH0T7\\SQLEXPRESS;Database=CourseDB;Trusted_Connection=True; TrustServerCertificate=True");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txt_username.Text;
            string pass = txt_password.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please Write the email correctly", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please Fill Email And Password Correctlly", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM Users WHERE Email = @email AND Password = @pass";

            var user = con.Query<User>(query, new { email, pass }).FirstOrDefault();
            id = user.Id;

            if (user != null)
            {
                if (user.Role == "student")
                {
                    MessageBox.Show("you logged successfully", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentPage page = new StudentPage(id);
                    page.ShowDialog();
                    this.Hide();
                }
                else if (user.Role == "instructor")
                {
                    MessageBox.Show("you logged successfully", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AdminPage page = new AdminPage(id);
                    page.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Failed to login", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowProfile showProfile = new ShowProfile(id);
            showProfile.ShowDialog();
        }
    }
}
      
    
     
  

