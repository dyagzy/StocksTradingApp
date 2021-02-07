using StockVest.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repository
{
    public interface ISecurity
    {
        Task CreateSecurityAsync(Security security);
        IEnumerable<Security> GetAll();
        Security GetById(int securityId);
        Task UpdateSecurity(Security security);
        Task UpdateSecurity(int securityId);
        Task Delete(int securityId);


    }
}
