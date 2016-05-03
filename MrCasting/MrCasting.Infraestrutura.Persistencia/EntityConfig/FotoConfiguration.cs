using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class FotoConfiguration : EntityTypeConfiguration<FotoObj>
    {

        public FotoConfiguration()
        {

            HasKey(c => c.Id);

            Property(c => c.Foto)
                .IsRequired();

            Property(c => c.DataCriacao)
                .IsOptional();

            Property(c => c.NomeFoto)
              .IsOptional();

            HasRequired<Candidato>(h => h.Candidato)
             .WithMany(c => c.AlbumFotos)
             .HasForeignKey(h => h.IdCandidato);


        }
    }
}
