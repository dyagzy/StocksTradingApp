using Microsoft.EntityFrameworkCore;
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


        public async Task<IEnumerable<Stocks>> GetAllAsync() => await _context.Stockss.ToListAsync();
        
          // I want to pick all the stocks whose id match what the user wants 
        //plus the market capitalization of that stock
        public async Task<Stocks> GetbyIdAsync(int stockId) => await _context.Stockss.Include(e => e.MarketCap).Where(s => s.Id == stockId).FirstOrDefaultAsync();

        public async Task CreateStockAsync(Stocks newStock)
        {
            if (newStock == null)
            {
                throw new ArgumentNullException(nameof(newStock));
            }
            await _context.AddAsync(newStock);
        }

        public Task Delete(int stockId)
        {
            throw new NotImplementedException();
        }

       

        public Task UpdateStockAsync(Stocks stocks)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStockAsync(int stockId)
        {
            throw new NotImplementedException();
        }


        // returns true if 1 or more entries were saved or changed
        public async Task<bool> SaveChangesAsync() => await _context.SaveChangesAsync() > 0;
        
           
        








        //Old Implementation





        ////public  async Task CreateStockAsync1(Stocks stock)
        ////{
        ////    await  _context.Stockss.AddAsync(stock);
        ////    await _context.SaveChangesAsync();
        ////    //return stock;
        ////}

        //public async Task<Stocks> CreateStockAsync(Stocks stock)
        //{
        //    await _context.Stockss.AddAsync(stock);
        //    await _context.SaveChangesAsync();
        //    return stock;
        //}


        //public Stocks GetbyId(int stockId) => _context.Stockss.Where(s => s.Id == stockId).FirstOrDefault();

        //public async  Task Delete(int stockId)
        //{
        //    var stocks = GetbyId(stockId);
        //    _context.Remove(stocks);
        //  await   _context.SaveChangesAsync();
        //}

        //public IEnumerable<Stocks> GetAll() => _context.Stockss;



        //public async  Task UpdateStockAsync(Stocks stocks)
        //{
        //    _context.Update(stocks);
        //    await _context.SaveChangesAsync();

        //}

        //public async Task UpdateStockAsync(int stockId)
        //{
        //    var stocks = GetbyId(stockId);
        //    _context.Update(stocks);
        //    await _context.SaveChangesAsync();
        //}

        //Stocks IStocksService.CreateStockAsync(Stocks stock)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
