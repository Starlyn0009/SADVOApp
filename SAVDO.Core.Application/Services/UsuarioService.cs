using AutoMapper;
using SADVOApp.Core.Application.Dtos.UsuarioDto;
using SADVOApp.Core.Application.Interfaces;
using SADVOApp.Core.Domain.Entities;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Core.Application.Services
{
    public class UsuarioService : GenericService<Usuario,UsuarioDto>,IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper) : base(usuarioRepository, mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
    }
}
