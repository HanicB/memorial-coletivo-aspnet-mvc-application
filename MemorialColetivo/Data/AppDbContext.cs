using MemorialColetivo.Models;
using Microsoft.EntityFrameworkCore;

namespace MemorialColetivo.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity < Usuario_Memorial>().HasKey(am => new{
                am.UsuarioId,
                am.MemorialId
            });

            modelBuilder.Entity<Usuario_Memorial>().HasOne(m => m.Memorial).WithMany(am => am.Usuario_Memorial).HasForeignKey(m => m.MemorialId);
            modelBuilder.Entity<Usuario_Memorial>().HasOne(m => m.Usuario).WithMany(am => am.Usuario_Memorial).HasForeignKey(m => m.UsuarioId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Memorial> Memorial { get; set; }
        public DbSet<Usuario_Memorial> Usuario_Memorial { get; set; }
    }
}
