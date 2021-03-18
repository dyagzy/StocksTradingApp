
using Stuck.Entity;
using Stuck.Repository.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Repository.Infrastructure
{
    public class MarketAndNewsService : IMarketAndNewsService
    {
        public IEnumerable<string> GetMarketNews()
        {
            throw new NotImplementedException();
        }

        public MarketQoutes GetMarkets()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TickerQoute> GetMarketTickerQoutes()
        {
            throw new NotImplementedException();
        }
    }
}
