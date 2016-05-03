using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class CaracteristicasFisicasConfiguration : EntityTypeConfiguration<CaracteristicasFisicas>
    {
        public CaracteristicasFisicasConfiguration()
        {

            HasKey(c => c.Id);

            Property(c => c.Altura)
                .IsOptional()
               .HasPrecision(4, 2);

            Property(c => c.Busto)
                 .IsOptional()
                .HasPrecision(4, 2);

            Property(c => c.Camisa)
                .IsOptional()
           .HasMaxLength(CaracteristicasFisicas.CamisaMaxSize);

            Property(c => c.Cintura)
                .IsOptional()
            .HasPrecision(4, 2);

            Property(c => c.ComprimentoCabelo)
                .IsOptional()
                .HasMaxLength(CaracteristicasFisicas.ComprimentoCabeloMaxSize);

            Property(c => c.CorOlhos)
                .IsOptional()
                .HasMaxLength(CaracteristicasFisicas.CorDosOlhosMaxLenght);

            Property(c => c.CorPele)
                .IsOptional()
                .HasMaxLength(CaracteristicasFisicas.CorDaPeleMaxLenght);

            Property(c => c.Descendencia)
                .IsOptional()
                .HasMaxLength(CaracteristicasFisicas.DescendenciaMaxSize);

            Property(c => c.Etnia)
                .IsOptional()
                .HasMaxLength(CaracteristicasFisicas.EtniaMaxSize);

            Property(c => c.Manequim)
                .IsOptional();

            Property(c => c.Peso)
                .IsOptional()
                .HasPrecision(5, 2);

            Property(c => c.Quadril)
                .IsOptional()
                .HasPrecision(4, 2);

            Property(c => c.Sapato)
                .IsOptional();

            Property(c => c.Terno)
                .IsOptional()
                .HasMaxLength(CaracteristicasFisicas.TernoMaxSize);

            Property(c => c.TipoCabelo)
                .IsOptional()
                .HasMaxLength(CaracteristicasFisicas.TipoCabeloMaxSize);

            Property(c => c.Torax)
                .IsOptional()
                .HasPrecision(4, 2);

            Property(c => c.TipoFisico)
                .IsOptional()
                .HasMaxLength(CaracteristicasFisicas.TipoFisicoMaxSize);

        }
    }
}


