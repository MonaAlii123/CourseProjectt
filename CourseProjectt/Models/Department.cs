using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace CourseProjectt.Models
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public string? ManagerName { get; set; }

        public virtual List<User> Users { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}
