using Proyecto.Aplication.Dtos.Producto;
using Proyecto.Entities;

namespace Proyecto.WebApi.Mapping
{
    public class ProductoMappingProfile
    {
        public ProductoMappingProfile()
        {
            //CreateMap<Product, ProductoResponseDto>().
            //    ForMember(dest => dest.FechaNacimiento, ori => ori.MapFrom(src => src.FechaNacimiento.ToShortDateString()));
            //CreateMap<ProductoRequestDto, Product>();
        }
    }
}
