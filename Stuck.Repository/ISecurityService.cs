
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
        Security GetSecurity(string symbol);
        Task UpdateSecurity(Security security);
        Task UpdateSecurity(string symbol);
        Task Delete(string symbol);
        IEnumerable<TickerQoute> GetSecurityTickerQoute();
       



    }
}
