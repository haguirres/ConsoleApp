using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddelName { get; set; }
        public string LastName { get; set; }
        public string MothersLastName { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public DateTime Birthdate { get; set; }
        public string PlaceOfBirth { get; set; }
    }
}
