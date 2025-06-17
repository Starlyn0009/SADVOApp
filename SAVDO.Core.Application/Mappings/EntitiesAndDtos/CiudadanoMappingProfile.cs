using AutoMapper;
using SADVOApp.Core.Application.Dtos.CiudadanoDto;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Core.Application.Mappings.EntitiesAndDtos
{
    public class CiudadanoMappingProfile : Profile
    {
        public CiudadanoMappingProfile()
        {
            CreateMap<Ciudadano, CiudadanoDto>().ReverseMap();
            CreateMap<Ciudadano, CreateCiudadanoDto>().ReverseMap();
            CreateMap<Ciudadano, UpdateCiudadanoDto>().ReverseMap();
        }
    }
}
