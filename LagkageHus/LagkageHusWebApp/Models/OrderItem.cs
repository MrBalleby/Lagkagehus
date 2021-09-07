using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagkageHusWebApp.Models
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
