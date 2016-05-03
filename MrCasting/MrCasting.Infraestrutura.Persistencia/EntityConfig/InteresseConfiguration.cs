using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class InteresseConfiguration : EntityTypeConfiguration<Interesse>
    {

        public InteresseConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.ModeloPlusSize)
                .IsOptional();

            Property(c => c.Modelo)
                .IsOptional();

            Property(c => c.Figurante)
                .IsOptional();

            Property(c => c.Evento)
                .IsOptional();

            Property(c => c.Ator)
                .IsOptional();

            Property(c => c.Outros)
               .IsOptional();

            Property(c => c.Mirin)
               .IsOptional();

        }

    }
}
