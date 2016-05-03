using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class ScouterConfiguration: EntityTypeConfiguration<Scouter>
    {
        public ScouterConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Agencia)
                .IsOptional();

            Property(c => c.Cnpj)
                .IsRequired();

            HasRequired<Pessoa>(c => c.DadosPessoais)
                          .WithOptional().Map(c => c.MapKey("IdPessoa"));


        }

    }
}
