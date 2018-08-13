using System.Linq;
using API.Core.Domain;
using API.Persistance.Configuration;
using Microsoft.EntityFrameworkCore;

namespace API.Persistance
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.SetNull;
            }

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}