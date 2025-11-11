using AutoMapper;
using Proyecto.Aplication.Dtos.Identity.Roles;
using Proyecto.Entities.MicrosoftIdentity;

namespace Proyecto.WebApi.Mapping
{
    public class RoleMappingProfile : Profile
    {
        public RoleMappingProfile()
        {
            CreateMap<Role, RoleResponseDto>();
            CreateMap<RoleRequestDto, Role>();
        }
    }
}
