using AutoMapper;
using CustomerService.Models;
using CustomerService.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService
{
    public class MapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConf = new MapperConfiguration(conf =>
            {
                conf.CreateMap<CustomerDto, Customer>();
                conf.CreateMap<Customer, CustomerDto>();
            });

            return mappingConf;
        }
    }
}
