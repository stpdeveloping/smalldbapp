using AutoMapper;
using Kotrak.Models;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kotrak.Mapping
{
    public class Wrapper
    {
        private static MapperConfiguration mapperConfiguration =
            new MapperConfiguration(cfg => 
            { 
                cfg.CreateMap<Buyer, Dto>(); 
            });
        public static IMapper GetMapper => mapperConfiguration.CreateMapper();
    }
}
