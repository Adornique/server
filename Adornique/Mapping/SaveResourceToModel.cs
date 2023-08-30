using AutoMapper;
using server.Adornique.Domain.Models;
using server.Adornique.Resource.Create;
using server.Adornique.Resource.View;

namespace server.Adornique.Mapping
{
    public class SaveResourceToModel : Profile
    {
        public SaveResourceToModel()
        {
            CreateMap<SaveAdminResource,Admin>();
            CreateMap<SaveCosmeticResource,Cosmetic>();
            CreateMap<SaveCustomerResource,Customer>();
            CreateMap<SaveJewelryResource, Jewelry>();
            CreateMap<SaveOrderLineResource, OrderLine>();
            CreateMap<SaveOrderResource, Order>();
            CreateMap<SavePaymentResource, Payment>();
            CreateMap<SaveProductResource, Product>();
            CreateMap<SaveStatusOrderResource, StatusOrder>();
            CreateMap<SaveUserResource,User>();
        }
    }
}
