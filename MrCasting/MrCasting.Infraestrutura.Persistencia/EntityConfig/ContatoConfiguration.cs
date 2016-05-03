using MrCasting.Domain.Entities;
using MrCasting.Domain.ValueObject;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class ContatoConfiguration : EntityTypeConfiguration<Contato>
    {
        public ContatoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Email.EnderecoDeEmail)
                .IsRequired()
                .HasMaxLength(Email.EnderecoMaxLength);

            Property(c => c.Telefone.Numero)
              .IsRequired();

            Property(c => c.Telefone.DDD)
            .IsRequired();

        }
    }
}
