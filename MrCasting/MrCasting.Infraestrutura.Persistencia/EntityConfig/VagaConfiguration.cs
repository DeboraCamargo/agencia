using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class VagaConfiguration : EntityTypeConfiguration<Vaga>
    {

        public VagaConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.DescricaoVaga)
                .IsOptional();

            Property(c => c.Status)
                .IsOptional();

            Property(c => c.TituloVaga)
                .IsRequired();

            HasRequired<Scouter>(c => c.ProprietarioVaga)
                              .WithRequiredDependent().Map(c => c.MapKey("IdScouter"));
        }

    }
}
