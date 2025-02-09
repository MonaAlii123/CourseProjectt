using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectt.Models
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Degree { get; set; }
        public int? MinDegree { get; set; }
        public int? Hours { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [ForeignKey("department")]
        public int? DepartmentId { get; set; }
        public Department department { get; set; }
        public virtual List<UserCourse> UserCourses { get; set; }
    }
}
