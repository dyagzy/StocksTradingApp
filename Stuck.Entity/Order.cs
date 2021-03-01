using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stuck.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int NumberOfShares { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal Price { get; set; }
        public BrokerageAccount BrokerageAccount { get; set; }
        public Security Security { get; set; }
        public OrderType OrderType { get; set; }
    }
}
