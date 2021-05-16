using System.ComponentModel.DataAnnotations.Schema;
using CepValidate.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CepValidate.Domain.Infra.Data
{
    [Table("Enderecamentos")]
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Enderecamento> Enderecamentos{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Enderecamento>().HasIndex(s => s.Id);
            modelBuilder.Entity<Enderecamento>().Property(s => s.Cep);
            modelBuilder.Entity<Enderecamento>().Property(s => s.Logradouro);
            modelBuilder.Entity<Enderecamento>().Property(s => s.Complemento);
            modelBuilder.Entity<Enderecamento>().Property(s => s.Bairro);
            modelBuilder.Entity<Enderecamento>().OwnsOne(s => s.Regiao).Property(x => x.Localidade);
            modelBuilder.Entity<Enderecamento>().OwnsOne(s => s.Regiao).Property(x => x.Uf);
            modelBuilder.Entity<Enderecamento>().Property(s => s.Ibge);
            modelBuilder.Entity<Enderecamento>().Property(s => s.Gia);
            modelBuilder.Entity<Enderecamento>().Property(s => s.DDD);
            modelBuilder.Entity<Enderecamento>().Property(s => s.Siafi);
            modelBuilder.FinalizeModel();

        }
    }
}