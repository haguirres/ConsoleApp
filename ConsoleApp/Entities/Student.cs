using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entities
{
    class Student:Person
    {
        public int StudentId { get; set; }
        public int Grade { get; set; }
        public string Average { get; set; }
    }
}
