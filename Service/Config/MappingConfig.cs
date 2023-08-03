using AutoMapper;
using AspNetCore.Service.Model;
using AspNetCore.Service.Data.ValueObjects;

namespace AspNetCore.Service.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration( config => {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}