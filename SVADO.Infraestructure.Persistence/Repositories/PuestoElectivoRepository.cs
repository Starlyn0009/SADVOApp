﻿using SADVO.Infraestructure.Persistence.Contexts;
using SADVOApp.Core.Domain.Entities;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Infraestructure.Persistence.Repositories
{
    public class UsuarioPartidoRepository : GenericRepository<UsuarioPartido>, IUsuarioPartidoRepository
    {
        private readonly SADVOAppContext _context;
        public UsuarioPartidoRepository(SADVOAppContext context) : base(context) // Llama al constructor de la clase base GenericRepository pasandole el contexto
        {
            _context = context;
        }
    }
}
