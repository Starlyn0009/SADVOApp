using SADVO.Infraestructure.Persistence.Contexts;
using SADVOApp.Core.Domain.Entities;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Infraestructure.Persistence.Repositories
{
    public class CandidatoRepository : GenericRepository<Candidato>, ICandidatoRepository
    {
        private readonly SADVOAppContext _context;
        public CandidatoRepository(SADVOAppContext context) : base(context) // Llama al constructor de la clase base GenericRepository pasandole el contexto
        {
            _context = context;
        }
    }
}
