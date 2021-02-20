using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Entity
{
    public class TradingInformation
    {
        public int Id { get; set; }
        public string TradingName { get; set; }
        public string TickerSymbol { get; set; }
        public string Sector { get; set; }
        public string SubSector { get; set; }
        public string MarketClassification { get; set; }
        public decimal MarketCap { get; set; }
        public decimal SharesOutstanding { get; set; }
        public DateTime OfficialOpen { get; set; }
        public DateTime OfficalClose { get; set; }

    }
}
