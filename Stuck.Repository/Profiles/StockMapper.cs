using AutoMapper;
using Stuck.Entity;
using Stuck.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Repository.Profiles
{
    public class StockMapper : Profile
    {
        public StockMapper()
        {
            CreateMap<Stocks, StockDto>();
        }
    }
}
