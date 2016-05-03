using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class HabilidadeConfiguration : EntityTypeConfiguration<Habilidade>
    {
        public HabilidadeConfiguration()
        {
            Property(c => c.NomeHabilidade)
                .IsRequired()
                .HasMaxLength(Habilidade.NomeHabilidaeMaxlengh);

            HasRequired<Candidato>(h => h.Candidato)
               .WithMany(c => c.Habilidade)
               .HasForeignKey(c => c.IdCandidato);
        }
    }
}
