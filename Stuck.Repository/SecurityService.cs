
using Stuck.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository
{
    public class SecurityService : ISecurityService
    {
        private readonly ApplicationDbContext _context;

        public SecurityService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async  Task CreateSecurityAsync(Security security)
        {

            await _context.Securities.AddAsync(security);
            await _context.SaveChangesAsync();
          
        }
        public Security GetBySymbol(string symbol) => _context.Securities.Where(s => s.Symbol == symbol).FirstOrDefault();
       

        public async Task Delete(string symbol)
        {
            var security = GetBySymbol(symbol);
            _context.Remove(security);
            await   _context.SaveChangesAsync();
        }

        public IEnumerable<Security> GetAll() => _context.Securities;
       


        public async Task UpdateSecurity(Security security)
        {
            _context.Update(security);
            await _context.SaveChangesAsync();
        }

        public  async Task UpdateSecurity(string symbol)
        {
            var security = GetBySymbol(symbol);
            _context.Update(security);
           await _context.SaveChangesAsync();
        }

        public IEnumerable<TickerQoute> GetSecurityTickerQoute()
        {
            /*  we went into the securities table, select all the properties in it and then
             *  project it into another object
             in this case we projected it into a TickerQoute object by creating an instance 
            of it and then doing the mapping
            */


           return _context.Securities.Select(s => new TickerQoute 
                                                                                                
            {
                Symbol = s.Symbol,
                Last = s.Last,
                Change = s.Change
            }).OrderBy(tq => tq.Symbol).ToList();
            
        }
    }
}
