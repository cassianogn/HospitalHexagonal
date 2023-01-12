using Dti.HospitalDDD.Atendimento.Domain.Senhas;
using Dti.HospitalDDD.Infrastructure.Data.FluentApis.Senhas;
using Microsoft.EntityFrameworkCore;

namespace Dti.HospitalDDD.Infrastructure.Data.DbContexts
{
    public class HospitalDTIDb : DbContext
    {
        public DbSet<Senha> Senhas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SenhaDbMap());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=HospitalDTI; User Id=SA; password=yourStrong(!)Password");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
