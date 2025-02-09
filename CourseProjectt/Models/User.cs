using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectt.Models
{
    internal class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        public int? Grade { get; set; }
        public string? phone {  get; set; }
        public string? Email {  get; set; }
        public string? Password {  get; set; }
        public string Role { get; set; }

        [ForeignKey("department")]
        public int? DepartmentId { get; set; }
        public Department department { get; set; }

        public  virtual List<UserCourse> UserCourses { get; set; }
    }
}
