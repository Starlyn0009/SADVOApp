using SADVOApp.Core.Domain.Common;
using SADVOApp.Core.Domain.Common.Enums;

namespace SADVOApp.Core.Domain.Entities
{
    public class Usuario : PersonaBase
    {
        
        public required string Email { get; set; }
        public required string NombreUsuario { get; set; }
        public required string PasswordHash { get; set; }
        public RolUsuario Rol { get; set; }

        // Relacion Usuario Partido si es dirigente politico
        public UsuarioPartido? UsuarioPartido { get; set; }
    }
    
}
