using AutoMapper;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.AutoMapper
{
    //convert
    //Application (view model) >> Domain (class)
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Product, ProductViewModel>(); //.ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name));
            //informing the automapper library that we are mapping/linking Product onto ProductViewModel

            CreateMap<Category, CategoryViewModel>();
            CreateMap<Member, MemberViewModel>();
        }
    }
}
