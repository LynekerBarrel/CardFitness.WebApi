using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api
{
    public partial class SIUGlobalContext : DbContext
    {
        public SIUGlobalContext()
        {
        }

        public SIUGlobalContext(DbContextOptions<SIUGlobalContext> options) : base(options)
        {
        }

        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<Exercicio> Exercicio { get; set; }
        public virtual DbSet<Ficha> Ficha { get; set; }
        public virtual DbSet<FichaExercicio> FichaExercicio { get; set; }
        public virtual DbSet<FilaFicha> FilaFicha { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStrings.Local);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // equivalent of modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                entityType.Relational().TableName = entityType.DisplayName();

                // equivalent of modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                // and modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }
        }

    }
}
