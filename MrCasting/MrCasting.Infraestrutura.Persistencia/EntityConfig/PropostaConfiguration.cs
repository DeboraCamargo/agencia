using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Infra.Data.EntityConfig
{
   public class PropostaConfiguration: EntityTypeConfiguration<Proposta>
    {
        public PropostaConfiguration () {

            HasKey(c => c.Id);

            Property(c => c.Cache)
                .IsOptional();

            Property(c => c.Status)
                .IsOptional();

            Property(c => c.DataEntrevista)
                .IsRequired();

            Property(c => c.DataExpiraProposta)
               .IsRequired();

            Property(c => c.DataFimJob)
               .IsOptional();

            Property(c => c.DataIncioJob)
               .IsOptional();

            Property(c => c.DetalhesProposta)
               .IsOptional();

            Property(c => c.NaoTemFinalDataDefinida)
               .IsOptional();

            HasRequired<Vaga>(c => c.Vaga)
                .WithRequiredDependent().Map(c => c.MapKey("IdVaga"));



        }
    }
}
