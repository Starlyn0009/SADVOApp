using SADVOApp.Core.Domain.Common.Enums;

namespace SADVOApp.Core.Application.Dtos.UsuarioDto
{
    public class UsuarioDto : PersonaBaseDto<int>
    {
        public required string Email { get; set; }
        public required string NombreUsuario { get; set; }
        public required string PasswordHash { get; set; }
        public RolUsuario Rol { get; set; }       
    }
}
