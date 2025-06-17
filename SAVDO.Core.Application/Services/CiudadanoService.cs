using AutoMapper;
using SADVOApp.Core.Application.Dtos.CiudadanoDto;
using SADVOApp.Core.Application.Interfaces;
using SADVOApp.Core.Domain.Entities;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Core.Application.Services
{
    public class CiudadanoService : GenericService<Ciudadano,CiudadanoDto>,ICiudadanoService
    {
        private readonly ICiudadanoRepository _ciudadanoRepository;
        private readonly IMapper _mapper;
        public CiudadanoService(ICiudadanoRepository ciudadanoRepository, IMapper mapper) : base(ciudadanoRepository, mapper)
        {
            _ciudadanoRepository = ciudadanoRepository;
            _mapper = mapper;
        }
    }
}
