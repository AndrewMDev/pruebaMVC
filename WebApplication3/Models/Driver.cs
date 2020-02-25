using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DNI { get; set; }
        public DateTime Birthday { get; set; }
        public int Phone { get; set; }
        public int Cellphone { get; set; }
        public string Address { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}
