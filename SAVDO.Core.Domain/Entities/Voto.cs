namespace SADVOApp.Core.Domain.Entities
{
    public class Voto
    {
        public int Id { get; set; }

        public int CiudadanoId { get; set; }
        public required Ciudadano Ciudadano { get; set; }

        public int EleccionId { get; set; }
        public required Eleccion Eleccion { get; set; }

        public int CandidatoId { get; set; }
        public required Candidato Candidato { get; set; }

        public int PuestoElectivoId { get; set; }
        public required PuestoElectivo PuestoElectivo { get; set; }

        public DateTime FechaVoto { get; set; }
    }
}
