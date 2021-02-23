using Stuck.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository
{
    public class StocksService : IStocksService
    {
        private readonly ApplicationDbContext _context;

        public StocksService(ApplicationDbContext context)
        {
            _context = context;
        }
        public  async Task CreateStockAsync(Stocks stock)
        {
            await  _context.Stockss.AddAsync(stock);
            await _context.SaveChangesAsync();
            //return stock;
        }


        public Stocks GetbyId(int stockId) => _context.Stockss.Where(s => s.Id == stockId).FirstOrDefault();
       
        public async  Task Delete(int stockId)
        {
            var stocks = GetbyId(stockId);
            _context.Remove(stocks);
          await   _context.SaveChangesAsync();
        }

        public IEnumerable<Stocks> GetAll() => _context.Stockss;
        


        public async  Task UpdateStockAsync(Stocks stocks)
        {
            _context.Update(stocks);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateStockAsync(int stockId)
        {
            var stocks = GetbyId(stockId);
            _context.Update(stocks);
            await _context.SaveChangesAsync();
        }
    }
}
