using AutoMapper;
using Proyecto.Aplication.Dtos.Deposito;
using Proyecto.Entities;

namespace Proyecto.WebApi.Mapping
{
    public class DepositoMappingProfile : Profile
    {
        public DepositoMappingProfile()
        {
            CreateMap<Deposito, DepositoResponseDto>();
            CreateMap<DepositoRequestDto, Deposito>();
        }
    }
}
