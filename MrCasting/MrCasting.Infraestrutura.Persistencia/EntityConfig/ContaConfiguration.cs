using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class ContaConfiguration : EntityTypeConfiguration<Conta>
    {
        public ContaConfiguration()
        {
            HasKey(c => c.Id);
            HasRequired<LoginOAuth>(c => c.Login);

            HasOptional<Candidato>(c => c.Candidato);
            HasOptional<Scouter>(c => c.Scouter);

        }

    }
}
