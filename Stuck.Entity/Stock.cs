using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stuck.Entity
{
    public class Stock 
    {
        public int Id { get; set; }
        public decimal Dividend { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal SellingPrice { get; set; }

        [Display(Name = "Openings" )]
        public decimal Opening { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal AverageVolume { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal NameOfShares { get; set; }
        public string Symbol { get; set; }

        [Column(TypeName = "decimal (18,2)"),Display(Name = "Weeks High 52")]
        public decimal YearLow { get; set; }
        [Column(TypeName = "decimal (18,2)")]
        public decimal Trades { get; set; }
      
        [Column(TypeName = "decimal (18,2)"), Display(Name = "Market Capilization")]
        public decimal MarketCap { get; set; }
        

        //[Column(TypeName = "decimal (18,2)")]
        //public decimal Change { get; set; }

        //[Column(TypeName = "decimal (18,2)"), Display(Name = "Percent Change")]
        //public decimal PercentChange { get; set; }
        //public int Lastings { get; set; }

        //[Display(Name = "Retrievla Date")]
        //public DateTime RetievalDateTime { get; set; }
        //public string Company { get; set; }

        //public decimal DayHigh { get; set; }
        //public decimal DayLow { get; set; }
        //public decimal Volume { get; set; }
        //[Column(TypeName = "decimal (18,2)")]
        //public decimal YearHigh { get; set; }
        //[Column(TypeName = "decimal (18,2)")]

        //[Display(Name = "Weeks High 52")]
        //public decimal _52WeeksHigh { get; set; }
        //[Column(TypeName = "decimal (18,2)")]

        //[Display(Name = "Weeks Low 52")]
        //public decimal _52WeeksLow { get; set; }


        //Navigation 

        public Balance Balances { get; set; }
        //public int ExchangeId { get; set; }
        public MutualFund MutualFund { get; set; }
        public Security Security { get; set; }
    }
}
