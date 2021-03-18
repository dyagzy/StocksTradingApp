
using Stuck.Entity;
using Stuck.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository.Service
{
    public interface IStocksService
    {


        Task CreateStockAsync(Stock newStock);
        Task<IEnumerable<Stock>> GetAllAsync();
        Task<Stock> GetbyIdAsync(int stockId);
        Task UpdateStockAsync(Stock stocks);
        Task UpdateStockAsync(int stockId);
        Task Delete(int stockId);
        Task<bool> SaveChangesAsync();
        Task<IEnumerable<StockDto>> GetAllAsync2();
        decimal Credit(decimal amount, decimal currentBalance, decimal initialBalance);
        decimal Debit(decimal amount, decimal currentBalance, decimal initialBalance);
        Task<IEnumerable<StockDto>> BuyStock(decimal currentBalance, string stockSymbol, decimal stockPrice);
        Task<decimal> CalculateStockValue(int numberOfStocks, decimal stockPrice);
        string SearchStock(params string[] stockName);



        //Old Implementation

        //Stocks CreateStockAsync(Stocks stock);
        //IEnumerable<Stocks> GetAll();
        //Stocks GetbyId(int stockId);
        //Task UpdateStockAsync(Stocks stocks);
        //Task UpdateStockAsync(int stockId);
        //Task Delete(int stockId);
        //Stocks BuyStock(int amount);
        //Stocks BuyStock(Stocks symbol);



    }
}
