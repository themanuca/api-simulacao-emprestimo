using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
    public class DBContext(DbContextOptions<DBContext> options) : DbContext(options)
    {
        public DbSet<Parcela> Parcela { get; set; }
        public DbSet<Proposta> Proposta { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=BaseEmprestimoDb;Encrypt=true;TrustServerCertificate=true;User Id=sa;Password=SenhaForte123!;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Parcela>()
                 .HasOne(p => p.Proposta)
                .WithMany(pr => pr.Parcelas)
                .HasForeignKey(p => p.PropostaId);
        }
    }
}
