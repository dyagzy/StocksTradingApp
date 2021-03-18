using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stuck.Entity
{
    public  class Security
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal Change { get; set; }
        public decimal PercentChange { get; set; }
        public int Last { get; set; }
        public decimal Shares { get; set; }
        public string Symbol { get; set; }
        public DateTime RetievalDateTime { get; set; }
        public string Company { get; set; }

        //Navigation  properties

        public IEnumerable<DataPoint> DataPoints { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<WatchList> WatchLists { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }

        public Position Position { get; set; }
    }
}
