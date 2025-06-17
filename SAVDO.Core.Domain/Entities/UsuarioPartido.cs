namespace SADVOApp.Core.Domain.Entities
{
    public class UsuarioPartido
    {
        public required int UsuarioId { get; set; }
        public required Usuario Usuario { get; set; }

        public required int PartidoId { get; set; }
        public required PartidoPolitico Partido { get; set; }
    }
}
