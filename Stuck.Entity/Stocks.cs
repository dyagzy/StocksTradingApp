using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
    public class Stocks : Security
    {
        public int Id { get; set; }
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public decimal Dividend { get; set; }
        public decimal Open { get; set; }
        public decimal Volume  { get; set; }
        public decimal YearHigh { get; set; }
        public decimal _52WeeksHigh { get; set; }
        public decimal _52WeeksLow { get; set; }
        public decimal YearLow { get; set; }
        
        public decimal Trades { get; set; }
        public decimal AverageVolume { get; set; }
        public decimal MarketCap { get; set; }
        public int ExchangeId { get; set; }


        //Navigation 

        public Exchange Exchange { get; set; }
    }
}
