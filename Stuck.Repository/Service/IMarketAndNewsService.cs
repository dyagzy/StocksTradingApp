
using Stuck.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Repository.Service
{
    public interface IMarketAndNewsService
    {
        MarketQoutes GetMarkets();
        IEnumerable<TickerQoute> GetMarketTickerQoutes();
        IEnumerable<string> GetMarketNews();
    }
}
