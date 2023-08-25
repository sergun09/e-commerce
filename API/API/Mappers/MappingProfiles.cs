using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Mappers
{
    internal class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(productDTO => productDTO.ProductBrand, o => o.MapFrom(brand => brand.ProductBrand.Name))
                .ForMember(productDTO => productDTO.ProductType, o => o.MapFrom(type=> type.ProductType.Name))
                .ForMember(productDTO => productDTO.PictureUrl, o => o.MapFrom<ProductResolver>());
        }
    }
}
