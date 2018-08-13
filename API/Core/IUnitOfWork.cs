using System;
using System.Threading.Tasks;
using API.Core.Repositories;

namespace API.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuarioRepositorio Usuarios { get; }
        Task CompleteAsync();
    }
}
