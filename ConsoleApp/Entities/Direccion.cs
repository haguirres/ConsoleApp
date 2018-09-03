using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entities
{
    class Direccion
    {
        public string Street { get; set; }
        public string OutNum { get; set; }
        public string IntNum { get; set; }
        public string Colonia { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
