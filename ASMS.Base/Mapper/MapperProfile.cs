using ASMS.Base.Entities;
using ASMS.Base.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Base.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Client, ClientDTO>(MemberList.Destination).ReverseMap();
            CreateMap<Car, CarDTO>(MemberList.Destination).ReverseMap();
            CreateMap<Order, OrderDTO>(MemberList.Destination).ReverseMap();
            CreateMap<Service, ServiceDTO>(MemberList.Destination).ReverseMap();
        }
    }
}
