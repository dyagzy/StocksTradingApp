using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
    public class OrderType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
