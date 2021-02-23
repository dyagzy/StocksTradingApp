using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stuck.Entity;
using Stuck.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StocksTrading.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStocksService _stocksService;

        public StocksController(IStocksService stocksService)
        {
            _stocksService = stocksService;
        }

        //public async Task<IActionResult> Create(Stocks stock)
        //{

        //    if (stock == null)
        //    {
        //        return BadRequest("Stock was not passed, please try again");
        //    }
        //    var stocks = await _stocksService.CreateStockAsync(stock);
        //    return stocks;
        //}
        public IActionResult GetAll()
        {
            return null;
        }

        [HttpGet]
      public IActionResult GetById(int id)
        {

            var stock = _stocksService.GetbyId(id);
            if (stock == null)
            {
                return BadRequest("The stock you selected was not avaialble");
            }
            return null;
        }

        public IActionResult Update(Stocks stocks)
        {
            return null;
        }

        public IActionResult Delete(Stocks stockId)
        {
            return null;
        }
             
    }
}
