using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseProjectt.Models
{
    [PrimaryKey(nameof(CourseId), nameof(UserId))]
    internal class UserCourse
    {
        public int? Grade { get; set; }
        public string? Status { get; set; }

        [ForeignKey("user")]
        public int UserId { get; set; }  
        public User user { get; set; }

        [ForeignKey("course")]
        public int CourseId { get; set; }  
        public Course course { get; set; }
       
    }
}
