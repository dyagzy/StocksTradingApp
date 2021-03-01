using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stuck.Entity
{
   public class Position
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal Shares { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal Total { get; set; }
        public int BrokerageAccountId { get; set; }

        //Navigation
        public int SecurityId { get; set; }
        public  Security Security { get; set; }
        public BrokerageAccount BrokerageAccount { get; set; }

    }
}
