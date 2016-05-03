using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {

        public EnderecoConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Uf)
                .IsRequired();

            Ignore(c => c.Cep);                

            Property(c => c.Cidade)
                .IsRequired()
                .HasMaxLength(Endereco.CidadeMaxLength);

            Property(c => c.Bairro)
                    .IsOptional()
                    .HasMaxLength(Endereco.BairroMaxLength);

            Property(c => c.Complemento)
                    .IsOptional()
                    .HasMaxLength(Endereco.ComplementoMaxLength);

            Property(c => c.Logradouro)
                .IsOptional()
                .HasMaxLength(Endereco.LogradouroMaxLength);

            Property(c => c.Numero)
                .IsOptional()
                .HasMaxLength(Endereco.NumeroMaxLength);

            Property(c => c.CepValue)
               .IsOptional();

        }
    }
}
