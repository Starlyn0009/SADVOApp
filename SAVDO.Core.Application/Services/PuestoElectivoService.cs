using AutoMapper;
using SADVOApp.Core.Application.Dtos.PuestoElectivoDto;
using SADVOApp.Core.Application.Interfaces;
using SADVOApp.Core.Domain.Entities;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Core.Application.Services
{
    public class PuestoElectivoService : GenericService<PuestoElectivo,PuestoElectivoDto>,IPuestoElectivoService 
    {
        private readonly IPuestoElectivoRepository _puestoElectivoRepository;
        private readonly IMapper _mapper;
        public PuestoElectivoService(IPuestoElectivoRepository puestoElectivoRepository, IMapper mapper) : base(puestoElectivoRepository, mapper)
        {
            _puestoElectivoRepository = puestoElectivoRepository;
            _mapper = mapper;
        }
    }
}
