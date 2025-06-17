using AutoMapper;
using SADVOApp.Core.Application.Dtos.PartidoPoliticoDto;
using SADVOApp.Core.Application.Interfaces;
using SADVOApp.Core.Domain.Entities;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Core.Application.Services
{
    public class PartidoPoliticoService : GenericService<PartidoPolitico,PartidoPoliticoDto>, IPartidoPoliticoService
    {
        private readonly IPartidoPoliticoRepository _partidoPoliticoRepository;
        private readonly IMapper _mapper;
        public PartidoPoliticoService(IPartidoPoliticoRepository partidoPoliticoRepository, IMapper mapper) : base(partidoPoliticoRepository, mapper)
        {
            _partidoPoliticoRepository = partidoPoliticoRepository;
            _mapper = mapper;
        }
    }
}
