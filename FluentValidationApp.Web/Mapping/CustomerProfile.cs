using AutoMapper;
using AutoMapper.Web.DTOs;
using FluentValidationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Mapping

{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            //CreateMap<Customer, CustomerDto>();
            //CreateMap<CustomerDto, Customer>();
            //CreateMap<Customer, CustomerDto>().ReverseMap();

            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(x => x.Age))
                //.ForMember(dest => dest.FullName, opt => opt.MapFrom(x => x.FullName2()))
                ;
            
        }
    }
}
