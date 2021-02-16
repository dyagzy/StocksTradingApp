using StockVest.Entity;
using Stuck.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository
{
    public interface ISecurityService
    {
        Task CreateSecurityAsync(Security security);
        IEnumerable<Security> GetAll();
        Security GetBySymbol(string symbol);
        Task UpdateSecurity(Security security);
        Task UpdateSecurity(string symbol);
        Task Delete(string symbol);
        IEnumerable<TickerQoute> GetSecurityTickerQoute();


    }
}
