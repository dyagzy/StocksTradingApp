using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Stuck.Entity;
using Stuck.Repository.Dto;
using Stuck.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository.Infrastructure
{
    public class StocksService : IStocksService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public StocksService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<Stock>> GetAllAsync() => await _context.Stocks.ToListAsync();
        public async Task<IEnumerable<StockDto>> GetAllAsync2()
        {
            var stock = await _context.Stocks.ToListAsync();
            return mapper.Map<IEnumerable<StockDto>>(stock);
        }


        // I want to pick all the stocks whose id match what the user wants 
        //plus the market capitalization of that stock
        public async Task<Stock> GetbyIdAsync(int stockId) => await _context.Stocks.Where(s => s.Id == stockId).FirstOrDefaultAsync();

        
        public async Task CreateStockAsync(Stock newStock)
        {
           
            await _context.AddAsync(newStock);
            await _context.SaveChangesAsync();
            
        }

        public Task Delete(int stockId)
        {
            throw new NotImplementedException();
        }



        public decimal Credit(decimal amount, decimal currentBalance , decimal initialBalance)
        {

            initialBalance += amount;
            return currentBalance = initialBalance;
        }

        public  decimal Debit(decimal amount, decimal currentBalance, decimal initialBalance)
        {
            if (initialBalance > amount)
            {
                initialBalance -= amount;
            }

            else
            {
                initialBalance =  0.0m;
            }
            if (initialBalance >= amount)
            {
                currentBalance -= amount;
            }

            return currentBalance;
        }

        public string SearchStock(params string[] stockName)
        {

            return null;
        }


        public  async Task UpdateStockAsync(Stock stocks)
        {
            _context.Update(stocks);
           await  _context.SaveChangesAsync();
        }

        public async Task UpdateStockAsync(int stockId)
        {
          var mg =   GetbyIdAsync(stockId);
            _context.Update(mg);
           await  _context.SaveChangesAsync();
        }



        // returns true if 1 or more entries were saved or changed
        public async Task<bool> SaveChangesAsync() => await _context.SaveChangesAsync() > 0;

        

        public Task<IEnumerable<StockDto>> BuyStock(decimal currentBalance, string stockSymbol, decimal stockPrice)
        {
            _context.Stocks
               
        }

        public Task<decimal> CalculateStockValue(int numberOfStocks, decimal stockPrice)
        {
            throw new NotImplementedException();
        }











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
