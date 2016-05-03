using MrCasting.Domain.Entities;
using MrCasting.Domain.ValueObject;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class CandidatoConfiguration : EntityTypeConfiguration<Candidato>
    {
        public CandidatoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.NomeFantasia)
              .IsRequired()
              .HasMaxLength(Candidato.NomeFantasiaMaxLenght);

            Property(c => c.SobrenomeFantasia)
                .IsOptional()
                .HasMaxLength(Candidato.SobrenomeFantasiaMaxLenght);

            Property(c => c.OrientacaoSexual)
                .IsOptional();

            Property(c => c.DRT)
                .IsOptional();

            Property(c => c.Nacionalidade)
                .IsOptional()
                .HasMaxLength(Candidato.NacionalidadeMaxLenght);

            Property(c => c.Naturalidade)
                .IsOptional()
                .HasMaxLength(Candidato.NaturalidadeMaxLenght);

            Property(c => c.Realise)
                .IsOptional()
                .HasMaxLength(Candidato.RealiseMaxLenght);

            Property(c => c.Profissao)
                .IsOptional()
                 .HasMaxLength(Candidato.ProfissaoMaxLenght);

            HasRequired<Pessoa>(c => c.DadosPessoais)
                .WithOptional().Map(c => c.MapKey("IdPessoa"));

            HasOptional<CaracteristicasFisicas>(c => c.CaracteristicaFisica)
                .WithOptionalDependent().Map(c => c.MapKey("IdCaracteristicaFisica"));


            HasMany<Tags>(c => c.Tags);

            HasMany<Habilidade>(s => s.Habilidade);
                
            HasMany<Hobby>(s => s.Hobby);

            HasMany<FotoObj>(s => s.AlbumFotos);

            HasMany<VideoObj>(s => s.AlbumVideos);

            HasRequired<Interesse>(c => c.Interesse)
               .WithRequiredDependent().Map(c => c.MapKey("IdInteresse"));

        }

    }
}
