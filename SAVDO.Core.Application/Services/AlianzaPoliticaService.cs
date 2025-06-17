using AutoMapper;
using SADVOApp.Core.Application.Dtos.AlianzaPoliticaDto;
using SADVOApp.Core.Application.Interfaces;
using SADVOApp.Core.Domain.Entities;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Core.Application.Services
{
    public class AlianzaPoliticaService : GenericService<AlianzaPolitica,AlianzaPoliticaDto>, IAlianzaPoliticaService
    {
        private readonly IAlianzaPoliticaRepository _alianzaPoliticaRepository;
        private readonly IMapper _mapper;
        public AlianzaPoliticaService(IAlianzaPoliticaRepository alianzaPoliticaRepository, IMapper mapper) : base(alianzaPoliticaRepository, mapper)
        {
            _alianzaPoliticaRepository = alianzaPoliticaRepository;
            _mapper = mapper;
        }
    }
}
