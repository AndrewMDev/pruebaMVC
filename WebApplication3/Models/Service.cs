using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Service
    {
        public int Id { get; set; }
        public int AmountService { get; set; }
        public decimal PaymentService { get; set; }
        public DateTime TripDate { get; set; }

    }
}
