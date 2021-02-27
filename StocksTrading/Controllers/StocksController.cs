using AutoMapper;
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
        private readonly IMapper _mapper;

        public StocksController(IStocksService stocksService, IMapper mapper)
        {
            _stocksService = stocksService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetStock()
        {
            var stock = await _stocksService.GetAllAsync();
            return Ok(stock);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetbyId(int stockId)
        {
            var stock = await _stocksService.GetbyIdAsync(stockId);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }

        [HttpPost]
        public Task<IActionResult> CreateStock([FromBody] )
        {
            return null;
        }

        //Old implementation

      //  public ActionResult<Stocks> Create(Stocks stock)
      //  {

      //      if (stock == null)
      //      {
      //          return BadRequest("Stock was not passed, please try again");
      //      }
      //      var stocks = _stocksService.CreateStockAsync(stock);
      //      return stocks;
      //  }
      //  public IActionResult GetAll()
      //  {
      //      return null;
      //  }

      //[HttpGet]
      //public IActionResult GetById(int id)
      //  {

      //      var stock = _stocksService.GetbyId(id);
      //      if (stock == null)
      //      {
      //          return BadRequest("The stock you selected was not avaialble");
      //      }
      //      return null;
      //  }

      //  public IActionResult Update(Stocks stocks)
      //  {
      //      return null;
      //  }

      //  public IActionResult Delete(Stocks stockId)
      //  {
      //      return null;
      //  }
             
    }
}
