using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Vehicle
    {
        public int Id{ get; set; }
        [Required]
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public IEnumerable<Service> Services { get; set; }

    }
}
