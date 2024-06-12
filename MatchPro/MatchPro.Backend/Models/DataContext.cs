using Microsoft.EntityFrameworkCore;

namespace MatchPro.Backend.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Grupo> Grupos { get; set; }

        public DbSet<Equipo> Equipos { get; set; }

        public DbSet<Torneo> Torneos { get; set; }

        public DbSet<DetalleGrupo> Detalles { get; set; }

        public DbSet<Partido> Partidos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Prediccion> Predicciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Partido>()
                .HasOne(p => p.Local)
                .WithMany()
                .HasForeignKey(p => p.EquipoLocalId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Partido>()
                .HasOne(p => p.Visitante)
                .WithMany()
                .HasForeignKey(p => p.EquipoVisitanteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Partido>()
                .HasOne(p => p.Grupo)
                .WithMany()
                .HasForeignKey(p => p.GrupoId)
                .OnDelete(DeleteBehavior.Restrict);
           
        }
    }
}
