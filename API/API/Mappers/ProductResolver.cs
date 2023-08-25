using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Mappers
{
    public class ProductResolver : IValueResolver<Product, ProductDTO, string>
    {
        private readonly IConfiguration config;

        public ProductResolver(IConfiguration config)
        {
            this.config = config;
        }

        public string Resolve(Product source, ProductDTO destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
                return $"{config["ApiUrl"]}{source.PictureUrl}";

            return string.Empty;
        }
    }
}
