using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt_Joban.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }

        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
