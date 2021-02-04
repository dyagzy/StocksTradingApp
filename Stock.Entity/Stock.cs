using System;
using System.Collections.Generic;
using System.Text;

namespace StockVest.Entity
{
    public class Stock : Security
    {
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public decimal Dividend { get; set; }
        public decimal Open { get; set; }
        public decimal Volume  { get; set; }
        public decimal YearHigh { get; set; }
        public decimal YearLow { get; set; }
        public decimal AverageVolume { get; set; }
        public decimal MarketCap { get; set; }
        public int ExchangeId { get; set; }
    }
}
