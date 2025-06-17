using AutoMapper;
using SADVOApp.Core.Application.Dtos.CandidatoDto;
using SADVOApp.Core.Application.Interfaces;
using SADVOApp.Core.Domain.Entities;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Core.Application.Services
{
    public class CandidatoService : GenericService<Candidato,CandidatoDto>, ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly IMapper _mapper;
        public CandidatoService(ICandidatoRepository candidatoRepository, IMapper mapper) : base(candidatoRepository, mapper)
        {
            _candidatoRepository = candidatoRepository;
            _mapper = mapper;
        }
    }
}
