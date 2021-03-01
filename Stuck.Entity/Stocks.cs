using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stuck.Entity
{
    public class Stocks 
    {
        public int Id { get; set; }
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public decimal Dividend { get; set; }
        public decimal Open { get; set; }
        public decimal Volume  { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal YearHigh { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal _52WeeksHigh { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal _52WeeksLow { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal YearLow { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal Trades { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal AverageVolume { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal MarketCap { get; set; }
        public int ExchangeId { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal Change { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal PercentChange { get; set; }
        public int Last { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal Shares { get; set; }
        public string Symbol { get; set; }
        public DateTime RetievalDateTime { get; set; }
        public string Company { get; set; }


        //Navigation 

        public Exchange Exchange { get; set; }
        public MutualFund MutualFund { get; set; }
        public Security Security { get; set; }
    }
}
