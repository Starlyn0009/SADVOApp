using SADVOApp.Core.Domain.Common;

namespace SADVOApp.Core.Domain.Entities
{
    public class PuestoElectivo : BaseEntiy<int>
    {
        public required string  Nombre { get; set; }
        public required string Descripcion { get; set; }

        // Navigation properties
        public ICollection<CandidatoPuesto> Candidatos { get; set; } = new List<CandidatoPuesto>();
    }
}
