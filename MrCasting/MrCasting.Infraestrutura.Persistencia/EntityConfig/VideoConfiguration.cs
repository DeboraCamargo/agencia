using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class VideoConfiguration: EntityTypeConfiguration<VideoObj>
    {

        public VideoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.NomeVideo)
                .IsOptional();

            Property(c => c.DataCriacao)
                .IsOptional();

            Property(c => c.Video)
              .IsRequired()
              .HasMaxLength(VideoObj.VideoMaxLenght);

            HasRequired<Candidato>(h => h.Candidato)
             .WithMany(c => c.AlbumVideos)
             .HasForeignKey(h => h.IdCandidato);

        }
    }
}
