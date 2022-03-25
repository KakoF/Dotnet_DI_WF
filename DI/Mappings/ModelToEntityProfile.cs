using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace DI.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<Customer, CustomerModel>().ReverseMap();
            CreateMap<Order, OrderModel>().ReverseMap();
            CreateMap<OrderItem, OrderItemModel>().ReverseMap();
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<Supplier, SupplierModel>().ReverseMap();
        }
      
    }
}
