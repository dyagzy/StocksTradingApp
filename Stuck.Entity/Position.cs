using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
   public class Position
    {
        public int Id { get; set; }
        public int SecurityId { get; set; }
        public decimal Shares { get; set; }
        public decimal Total { get; set; }
        public int BrokerageAccountId { get; set; }

        //Navigation
        public  Security Security { get; set; }
        public BrokerageAccount BrokerageAccount { get; set; }

    }
}
