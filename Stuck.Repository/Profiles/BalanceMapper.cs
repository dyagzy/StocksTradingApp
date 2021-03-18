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
    public class BalanceMapper :Profile
    {
        public BalanceMapper()
        {
            CreateMap<Balance, BalanceDto>().ReverseMap();


            //CreateMap<Balance, BalanceDto>().ReverseMap()
            // .ForMember(dest => dest.CurrentBalance,
            //                                 opt => opt.MapFrom(src => $"{ src.}"));


        }
    }
}
