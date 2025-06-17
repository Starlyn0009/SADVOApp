using AutoMapper;
using SADVOApp.Core.Application.Dtos;
using SADVOApp.Core.Domain.Common;

namespace SADVOApp.Core.Application.Mappings.EntitiesAndDtos
{
    public class BaseEntityMappingProfile : Profile
    {
        public BaseEntityMappingProfile() 
        {
            CreateMap(typeof(BaseEntityDto<>), typeof(BaseEntiy<>)).ReverseMap();
        }
    }
}
