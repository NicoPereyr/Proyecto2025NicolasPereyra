using AutoMapper;
using Proyecto.Aplication.Dtos.Categoria;
using Proyecto.Entities;

namespace Proyecto.WebApi.Mapping
{
    public class CategoriaMappingProfile:Profile
    {
        public CategoriaMappingProfile()
        {
            CreateMap<Categoria, CategoriaResponseDto>();
            CreateMap<CategoriaRequestDto, Categoria>();
        }
    }
}
