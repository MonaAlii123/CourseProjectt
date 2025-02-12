using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseProjectt.Models
{
    internal class StudentContextt : DbContext
    {
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<UserCourse> usercourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FRBH0T7\\SQLEXPRESS;Database=CourseDB;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }





    }
}


