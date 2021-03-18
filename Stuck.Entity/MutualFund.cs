using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
    public class MutualFund 
    {
        public int Id { get; set; }
        public int MorningStarRating { get; set; }
        public decimal Change { get; set; }
        public decimal PercentChange { get; set; }
        public int Last { get; set; }
        public decimal Shares { get; set; }
        public string Symbol { get; set; }
        public DateTime RetievalDateTime { get; set; }
        public string Company { get; set; }

        //Naviagtion property

        public IEnumerable<Stock> Stocks { get; set; }
    }
}
