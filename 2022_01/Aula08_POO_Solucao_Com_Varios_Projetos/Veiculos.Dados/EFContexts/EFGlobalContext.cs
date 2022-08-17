using Microsoft.EntityFrameworkCore;
using Veiculos.Modelo;

namespace Veiculos.Dados.EFContexts
{
    internal class EFGlobalContext : DbContext
    {

        public DbSet<MarcaModelo> Marcas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=POO_EF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<MarcaModelo>(entity =>
        //       {
        //           entity.HasKey(e => e.MarcaID);
        //           entity.ToTable("Marcas");
        //       }
        //    );
        //}
    }
}
