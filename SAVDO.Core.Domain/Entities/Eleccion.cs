using SADVOApp.Core.Domain.Common;
using SADVOApp.Core.Domain.Common.Enums;

namespace SADVOApp.Core.Domain.Entities
{
    public class Eleccion : BaseEntiy<int>
    {
        public  required string  Nombre { get; set; } 

        public DateTime Fecha { get; set; }
        public EstadoEleccion EstadoEleccion { get; set; }

        // Navigation properties
        public ICollection<Voto> Votos { get; set; } = new List<Voto>();
    }
}
