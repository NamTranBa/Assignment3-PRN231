using AutoMapper;
using BusinessObject.DTO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutoMapper.Internal.ExpressionFactory;

namespace BusinessObject
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Order, OrderComposeDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, AddProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<ApplicationUser, ApplicationUserDTO>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();
            CreateMap<Order, OrderDetail>().ForMember(c => c.OrderId, o => o.MapFrom(src => src.OrderId));
            CreateMap<Order, OrderComposeDTO>()
                      .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.OrderId))
                      .ForMember(dest => dest.MemberId, opt => opt.MapFrom(src => src.MemberId))
                      .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate))
                      .ForMember(dest => dest.RequiredDate, opt => opt.MapFrom(src => src.RequiredDate))
                      .ForMember(dest => dest.ShippedDate, opt => opt.MapFrom(src => src.ShippedDate))
                      .ForMember(dest => dest.Freight, opt => opt.MapFrom(src => src.Freight))
                      .ForMember(dest => dest.ProductId, opt => opt.Ignore()) 
                      .ForMember(dest => dest.UnitPrice, opt => opt.Ignore())
                      .ForMember(dest => dest.Quantity, opt => opt.Ignore())
                      .ForMember(dest => dest.Discount, opt => opt.Ignore()).ReverseMap();
            CreateMap<OrderDetailDTO, OrderComposeDTO>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.OrderId))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount)).ReverseMap();
        }
    }
}
