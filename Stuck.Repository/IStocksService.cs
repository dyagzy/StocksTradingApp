
using Stuck.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository
{
    public interface IStocksService
    {
        Task CreateStockAsync(Stocks stock);
        IEnumerable<Stocks> GetAll();
        Stocks GetbyId(int stockId);
        Task UpdateStockAsync(Stocks stocks);
        Task UpdateStockAsync(int stockId);
        Task Delete(int stockId);

    }
}
