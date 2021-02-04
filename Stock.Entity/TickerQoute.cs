using System;
using System.Collections.Generic;
using System.Text;

namespace StockVest.Entity
{
    public class TickerQoute
    {
        public long Id { get; set; }
        public string Symbol { get; set; }
        public decimal Last { get; set; }
        public decimal Change { get; set; }
    }
}
