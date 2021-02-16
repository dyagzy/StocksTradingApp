using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
    public abstract class Security
    {
        public int Id { get; set; }
        public decimal Change { get; set; }
        public decimal PercentChange { get; set; }
        public int Last { get; set; }
        public decimal Shares { get; set; }
        public string Symbol { get; set; }
        public DateTime RetievalDateTime { get; set; }
        public string Company { get; set; }
    }
}
