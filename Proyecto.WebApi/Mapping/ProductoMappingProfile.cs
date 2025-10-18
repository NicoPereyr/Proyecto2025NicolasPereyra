using AutoMapper;
using Proyecto.Aplication.Dtos.Producto;
using Proyecto.Entities;

namespace Proyecto.WebApi.Mapping
{
    public class ProductoMappingProfile: Profile
    {
        public ProductoMappingProfile()
        {
            CreateMap<Product, ProductoResponseDto>();
            CreateMap<ProductoRequestDto, Product>();
        }
    }
}
