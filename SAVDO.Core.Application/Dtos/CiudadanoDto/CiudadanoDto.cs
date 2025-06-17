namespace SADVOApp.Core.Application.Dtos.CiudadanoDto
{
    public class CiudadanoDto : PersonaBaseDto<int>
    {
        public required string Email { get; set; }
        public required string Cedula { get; set; }
        public required bool HaVotado { get; set; }
    }
}
