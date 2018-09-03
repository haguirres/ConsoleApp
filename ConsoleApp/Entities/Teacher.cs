using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entities
{
    public class Teacher : Person
    {
        public int TeacherId { get; set; }
        public int TeacherLevel { get; set; }
        public string Area { get; set; }
        public string Signature { get; set; }
    }
}
