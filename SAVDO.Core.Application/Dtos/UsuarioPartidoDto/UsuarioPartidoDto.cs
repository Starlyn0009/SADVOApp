namespace SADVOApp.Core.Application.Dtos.UsuarioPartidoDto
{
    public class UsuarioPartidoDto : BaseEntityDto<int>
    {
        public int UsuarioId { get; set; }
        public int PartidoPoliticoId { get; set; }

    }
}
