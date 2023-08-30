using AutoMapper;
using server.Adornique.Domain.Models;
using server.Adornique.Resource.View;

namespace server.Adornique.Mapping
{
    public class ModelToResource:Profile
    {
        public ModelToResource() {
            CreateMap<Admin, AdminResource>();
            CreateMap<Cosmetic, CosmeticResource>();
            CreateMap<Customer, CustomerResource>();
            CreateMap<Jewelry, JewelryResource>();
            CreateMap<OrderLine, OrderLineResource>();
            CreateMap<Order, OrderResource>();
            CreateMap<Payment, PaymentResource>();
            CreateMap<Product, ProductResource>();
            CreateMap<StatusOrder, StatusOrderResource>();
            CreateMap<User, UserResource>();
        }
    }
}
