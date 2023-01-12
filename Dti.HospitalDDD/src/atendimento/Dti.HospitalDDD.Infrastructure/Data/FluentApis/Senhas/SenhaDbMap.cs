using Dti.HospitalDDD.Atendimento.Domain.Senhas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dti.HospitalDDD.Infrastructure.Data.FluentApis.Senhas
{
    public class SenhaDbMap : IEntityTypeConfiguration<Senha>
    {
        public void Configure(EntityTypeBuilder<Senha> builder)
        {
            builder.HasKey(senha => senha.Id);
            builder.Property(senha => senha.Codigo).IsRequired().HasMaxLength(10);
        }
    }
}
