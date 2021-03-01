
using Stuck.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository
{
    public interface IStocksService
    {


        Task CreateStockAsync(Stocks newStock);
        Task<IEnumerable<Stocks>> GetAllAsync();
        Task<Stocks> GetbyIdAsync(int stockId);
        Task UpdateStockAsync(Stocks stocks);
        Task UpdateStockAsync(int stockId);
        Task Delete(int stockId);
        Task<bool> SaveChangesAsync();

       

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
