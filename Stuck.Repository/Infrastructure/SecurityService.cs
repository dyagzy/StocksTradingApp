
using Stuck.Entity;
using Stuck.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository.Infrastructure
{
    public class SecurityService : ISecurityService, IDisposable
    {

        private readonly string[] _securitySymbols = {"DANGCOM", "ACCESS", "AFRINSURE", 
                                                        "AIICO", "ABCTRANS", "GOLDINSURE",
                                                        "CUSTODIAN", "FIDELITYBK","GUARANTY",
                                                        "FBNH","JAIZBANK","FCMB", "UNHOMES",
                                                        "WAPIC","CAPOIL","OANDO","SEPLAT",
                                                        "ETERNA","CADBURY","FLOURMILL",
                                                        "HONYFLOUR","GUINNESS","DUNLOP",
                                                        "DANGSUGAR","NASCON","UNILEVER",
                                                        "VITAFOAM","NESTLE","PZ","NEIMETH",
                                                        "NB","MULTITREX", "EVANSMED",
                                                        "PHARMDEKO","GLAXOSMITH","MAYBAKER"};


        private readonly ApplicationDbContext _context;

        public SecurityService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateSecurityAsync(Security security)
        {

            await _context.Securities.AddAsync(security);
            await _context.SaveChangesAsync();
          
        }
        public Security GetSecurity(string symbol)
        {
           var sec =  _context.Securities.Where(s => s.Symbol == symbol).SingleOrDefault();
            if (sec == null)
            {
                var engine = new StocksEngine();
                //sec =  engine.GetSecurityQoute(symbol);

                _context.Securities.Add(sec);
            }

            return sec;
        }
        
        public async Task Delete(string symbol)
        {
            var security = GetSecurity(symbol);
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
            var security = GetSecurity(symbol);
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

        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
           
        }
        protected virtual  void Dispose(bool disposing)
        {

            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    //_context = null;
                }
                
            }
           
        }



    }
}
