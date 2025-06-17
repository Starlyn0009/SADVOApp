using SADVO.Infraestructure.Persistence.Contexts;
using SADVOApp.Core.Domain.Entities;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Infraestructure.Persistence.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        private readonly SADVOAppContext _context;
        public UsuarioRepository(SADVOAppContext context) : base(context) 
        {
            _context = context;
        }
    }
}
