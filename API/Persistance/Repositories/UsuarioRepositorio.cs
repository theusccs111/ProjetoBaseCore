using API.Core.Domain;
using API.Core.Repositories;

namespace API.Persistance.Repositories
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        private readonly Contexto _context;

        public UsuarioRepositorio(Contexto republicManagerContext) : base(republicManagerContext)
        {
            _context = republicManagerContext;
        }
    }
}