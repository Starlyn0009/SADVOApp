using AutoMapper;
using SADVOApp.Core.Application.Dtos.UsuarioDto;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Core.Application.Mappings.EntitiesAndDtos
{
    public class UsuarioMappingProfile : Profile
    {
        public UsuarioMappingProfile()
        {
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Usuario, CreateUsuarioDto>().ReverseMap();
            CreateMap<Usuario, UpdateUsuarioDto>().ReverseMap();
        }
    }
}
