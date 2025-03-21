﻿using ASMS.Base.Entities;
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
            CreateMap<OrderDTO, Order>(MemberList.Destination)
             .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.ClientId)) 
            .ForMember(dest => dest.CarId, opt => opt.MapFrom(src => src.CarId)) 
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status)); 
            ;
            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.ClientName, opt => opt.MapFrom(src => src.Client.Name)) 
                .ForMember(dest => dest.CarInfo, opt => opt.MapFrom(src => $"{src.Car.Brand} " +
                                                                 $"{src.Car.Model} {src.Car.RegNumber}")) 
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));
            CreateMap<OrderServices, ServiceDTO>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ServiceId));
            CreateMap<Service, ServiceDTO>(MemberList.Destination).ReverseMap();
        }
    }
}
