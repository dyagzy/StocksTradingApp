﻿using StockVest.Entity;
using Stuck.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Repository
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
