using AutoMapper;
using Proyecto.Aplication.Dtos.Marcas;
using Proyecto.Entities;

namespace Proyecto.WebApi.Mapping
{
    public class MarcaMappingProfile : Profile
    {
        public MarcaMappingProfile()
        {
            CreateMap<Marca, MarcaResponseDto>();
            CreateMap<MarcaRequestDto, Marca>();
        }
    }
}
