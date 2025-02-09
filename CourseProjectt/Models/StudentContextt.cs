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
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Department>().HasData(new Department() { Id = 1, Name = "OS", Manager = "mona" });
        //    modelBuilder.Entity<Department>().HasData(new Department() { Id = 2, Name = "PI", Manager = "moaz" });
        //    modelBuilder.Entity<Department>().HasData(new Department() { Id = 3, Name = "Front", Manager = "doha" });
        //    modelBuilder.Entity<Department>().HasData(new Department() { Id = 4, Name = "DotNet", Manager = "ayaat" });
        //    modelBuilder.Entity<Department>().HasData(new Department() { Id = 5, Name = "PHP", Manager = "eman" });

        //    modelBuilder.Entity<Course>().HasData(new Course() { Id = 1, Name = "MVC", Degree = 90, MinDegree = 50, Hours = 120, DeptId = 1 });
        //    modelBuilder.Entity<Course>().HasData(new Course() { Id = 2, Name = "WEBAPI", Degree = 80, MinDegree = 60, Hours = 120, DeptId = 2 });
        //    modelBuilder.Entity<Course>().HasData(new Course() { Id = 3, Name = "NETWORK", Degree = 70, MinDegree = 70, Hours = 120, DeptId = 3 });
        //    modelBuilder.Entity<Course>().HasData(new Course() { Id = 4, Name = "HTML", Degree = 60, MinDegree = 80, Hours = 120, DeptId = 4 });
        //    modelBuilder.Entity<Course>().HasData(new Course() { Id = 5, Name = "CSS", Degree = 50, MinDegree = 90, Hours = 120, DeptId = 5 });

        //    modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id = 1, Name = "aya", Image = "mona.jpg", Salary = 23000, Address = "tanta", DeptId = 1, CrsId = 1 });
        //    modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id = 2, Name = "ola", Image = "doha.jpg", Salary = 13000, Address = "menofya", DeptId = 2, CrsId = 2 });
        //    modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id = 3, Name = "eman", Image = "eman.jpg", Salary = 18000, Address = "cairo", DeptId = 3, CrsId = 3 });
        //    modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id = 4, Name = "zain", Image = "moaz.jpg", Salary = 10000, Address = "tanta", DeptId = 4, CrsId = 4 });
        //    modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id = 5, Name = "ahmed", Image = "ahmed.jpg", Salary = 15000, Address = "menofya", DeptId = 5, CrsId = 5 });

        //    modelBuilder.Entity<Trainee>().HasData(new Trainee() { Id = 1, Name = "seham", Image = "mona.jpg", Address = "tanta", Grade = 90, DeptId = 1 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee() { Id = 2, Name = "sara", Image = "doha.jpg", Address = "menofya", Grade = 80, DeptId = 2 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee() { Id = 3, Name = "basma", Image = "eman.jpg", Address = "cairo", Grade = 70, DeptId = 3 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee() { Id = 4, Name = "mohamed", Image = "moaz.jpg", Address = "tanta", Grade = 60, DeptId = 4 });
        //    modelBuilder.Entity<Trainee>().HasData(new Trainee() { Id = 5, Name = "ayman", Image = "ahmed.jpg", Address = "menofya", Grade = 50, DeptId = 5 });

        //    modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id = 1, Degree = 50, CrsId = 1, TraineeId = 1 });
        //    modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id = 2, Degree = 60, CrsId = 2, TraineeId = 2 });
        //    modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id = 3, Degree = 70, CrsId = 3, TraineeId = 3 });
        //    modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id = 4, Degree = 80, CrsId = 4, TraineeId = 4 });
        //    modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id = 5, Degree = 90, CrsId = 5, TraineeId = 5 });



        //    base.OnModelCreating(modelBuilder);
        //}

    }
}


