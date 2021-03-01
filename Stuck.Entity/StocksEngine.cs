using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Entity
{
    public class StocksEngine
    {

        //Sample or Dummy NSE Api they are just  placeholders for now

        private const string BaseUrl_1 = "http://marketdataapi.nse.com.ng/v2/api/index/indexmembers.json?s=ASI&_t=Dud70!kl";
        private const string BaseUrl_2 = "https://marketdataapi.nse.com.ng:8447/v2/api/index/indexmembers.json?s=ASI&_t=Dud70!kl";
        private const string BaseUrl_3 = "http://marketdataapi.nse.com.ng/version/product.{format}?{parameters}_t={token}";
       
        private readonly string _Separator = "&stock=";


        public int Id { get; set; }

        //These are methods that will make the external Api calls to the NSE Api to fehc data
        public StocksEngine GetSecurityQoute(string symbol)
        {
            return null;
        }

        public List<Security> GetSecurityQoutes(params string [] symbols)
        {
            return null;
        }


        public List<MarketIndex> GetMarketQoutes(string[] symbols)
        {
            return null;
        }

    }
}
