using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class HobbyConfiguration : EntityTypeConfiguration<Hobby>
    {
        public HobbyConfiguration()
        {
            Property(c => c.NomeHobby)
                .IsRequired()
                .HasMaxLength(Hobby.NomeHobbyMaxLenght);

            HasRequired<Candidato>(h => h.Candidato)
                .WithMany(c => c.Hobby)
                .HasForeignKey(h => h.IdCandidato);
        }
    }
}
