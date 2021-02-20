using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int NumberOfShares { get; set; }
        public decimal Price { get; set; }
        public BrokerageAccount BrokerageAccount { get; set; }
        public Security Security { get; set; }
        public OrderType OrderType { get; set; }
    }
}
