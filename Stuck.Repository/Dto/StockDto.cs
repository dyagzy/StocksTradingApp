using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository.Dto
{
    public class StockDto
    {

        public decimal AverageVolume { get; set; }
        public decimal MarketCap { get; set; }
        public decimal NameOfShares { get; set; }
        public string Symbol { get; set; }
        public string Company { get; set; }
        public decimal SellingPrice { get; set; }

        //public decimal DayHigh { get; set; }
        //public decimal DayLow { get; set; }
        //public decimal Dividend { get; set; }
        //public decimal Open { get; set; }
        //public decimal Volume { get; set; }
        //public decimal YearHigh { get; set; }
        //public decimal _52WeeksHigh { get; set; }
        //public decimal _52WeeksLow { get; set; }
        //public decimal YearLow { get; set; }
        //public decimal Trades { get; set; }

    }
}

