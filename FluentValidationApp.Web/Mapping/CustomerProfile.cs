﻿using AutoMapper;
using AutoMapper.Web.DTOs;
using FluentValidationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Mapping

{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            //CreateMap<Customer, CustomerDto>();
            //CreateMap<CustomerDto, Customer>();
            //CreateMap<Customer, CustomerDto>().ReverseMap();

            CreateMap<CreditCard, CustomerDto>();
            CreateMap<Customer, CustomerDto>().IncludeMembers(x=>x.CreditCard)
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(x => x.Age))
                ////.ForMember(dest => dest.FullName, opt => opt.MapFrom(x => x.FullName2()))
                //.ForMember(dest => dest.CCNumber, opt => opt.MapFrom(x => x.CreditCard.Number))
                //.ForMember(dest => dest.CCValidDate, opt => opt.MapFrom(x => x.CreditCard.ValidDate))
                ;

        }
    }
}
