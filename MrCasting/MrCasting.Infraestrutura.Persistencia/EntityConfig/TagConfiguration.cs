using MrCasting.Domain.Entities;
using MrCasting.Domain.ValueObject;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class TagConfiguration : EntityTypeConfiguration<Tags>
    {
        public TagConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Tag)
                          .IsRequired()
                          .HasMaxLength(Tags.TagMaxLenght);

            HasRequired<Candidato>(h => h.Candidato)
                .WithMany(c => c.Tags)
                .HasForeignKey(h => h.IdCandidato);
        }       

    }
}
