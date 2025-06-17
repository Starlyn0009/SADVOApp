namespace SADVOApp.Core.Domain.Entities
{
    public class CandidatoPuesto
    {
        public  int Id { get; set; }
        public  int CandidatoId { get; set; }
        public required Candidato Candidato { get; set; }
        public int PuestoElectivoId { get; set; }
        public required PuestoElectivo PuestoElectivo { get; set; }
        public int PartidoId { get; set; }
        public required PartidoPolitico Partido { get; set; }
    }
}
