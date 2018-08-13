using System.Threading.Tasks;
using API.Core;
using API.Core.Repositories;
using API.Persistance.Repositories;

namespace API.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Contexto _context;

        public IUsuarioRepositorio Usuarios { get; set; }

        public UnitOfWork(Contexto context)
        {
            _context = context;
            //Example Below
            Usuarios = new UsuarioRepositorio(_context);

        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
