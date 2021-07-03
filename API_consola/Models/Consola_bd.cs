using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace API_consola.Models
{
    public partial class Consola_bd : DbContext
    {
        public Consola_bd()
            : base("name=Consola_bd")
        {
        }

        public virtual DbSet<Consola> Consolas { get; set; }
        public virtual DbSet<Juego> Juegos { get; set; }
        public virtual DbSet<Mando> Mandos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consola>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Consola>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Consola>()
                .Property(e => e.nueva)
                .IsUnicode(false);

            modelBuilder.Entity<Juego>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Juego>()
                .Property(e => e.plataforma)
                .IsUnicode(false);

            modelBuilder.Entity<Mando>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Mando>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Mando>()
                .Property(e => e.compatibilidad)
                .IsUnicode(false);
        }
    }
}
