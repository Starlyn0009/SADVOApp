using AutoMapper;
using SADVOApp.Core.Application.Dtos.CiudadanoDto;
using SADVOApp.Core.Application.Dtos.PuestoElectivoDto;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Core.Application.Mappings.EntitiesAndDtos
{
    public class PuestoElectivoMappingProfile : Profile
    {
        public PuestoElectivoMappingProfile()
        {
            CreateMap<PuestoElectivo,PuestoElectivoDto>().ReverseMap(); 
            CreateMap<PuestoElectivo,CreateCiudadanoDto>().ReverseMap(); 
            CreateMap<PuestoElectivo,UpdatePuestoElectivoDto>().ReverseMap(); 
        }
    }
}
