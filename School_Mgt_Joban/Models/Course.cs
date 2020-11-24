using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt_Joban.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
