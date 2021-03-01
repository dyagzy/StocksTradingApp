using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stuck.Entity
{
    public class TickerQoute
    {
        public long Id { get; set; }
        public string Symbol { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal Last { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal Change { get; set; }
    }
}
