using MrCasting.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MrCasting.Infra.Data.EntityConfig
{
    public class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(Pessoa.NomeMaxLenght);

            Property(c => c.SobreNome)
               .IsRequired()
               .HasMaxLength(Pessoa.SobrenomeMaxLenght);

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.Cpf.Codigo)
              .IsRequired();

            Property(c => c.Sexo)
               .IsRequired();

            HasRequired<Contato>(c => c.Contato)
              .WithOptional().Map(c => c.MapKey("idContato"));

            HasOptional<Endereco>(c => c.Endereco).WithOptionalPrincipal();

            Property(c => c.FotoPerfil);

        }

    }
}
