using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entities
{
    public class School
    {
        public int SchoolID { get; set; }
        public string SchoolName { get; set; }
        public string SchoolLevel { get; set; }
        public bool SchoolPublic { get; set; }
    }
}
