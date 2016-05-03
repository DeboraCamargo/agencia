using MrCasting.Domain.Entities;
using MrCasting.Domain.Exceptions;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System.Data.Entity;
using System.Linq;

namespace MrCasting.Infra.Data.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        /// <summary>
        /// Alex Não tem interface para ele no domain. Tá correto???? te amo
        /// </summary>
        protected readonly DbSet<Endereco> EnderecoDb;
        protected readonly DbSet<Pessoa> PessoaDb;
        private readonly PessoaRepository pessoaRepository;

        public EnderecoRepository(GeneralContext context) : base(context)
        {
            EnderecoDb = context.Enderecos;
            PessoaDb = context.Pessoas;
            pessoaRepository = new PessoaRepository(context);
        }

        public void CadastrarEndereco(Endereco endereco)
        {
            Add(endereco);
            Commit();
        }

        public void EditarEndereco(int idPessoa, Endereco enderoco)
        {
            Pessoa pessoa = PessoaDb.Where(c => c.Id == idPessoa).Include("Endereco").FirstOrDefault();
            if (pessoa == null)
                throw new CandidatoNaoEncontradoException();

            Endereco end = pessoa.Endereco;
            if (end == null)
            {
                pessoa.Endereco = enderoco;
                pessoaRepository.Update(pessoa);
                Commit();
            }
            else
            {
                end.Bairro = enderoco.Bairro;
                end.Cep = enderoco.Cep;
                end.Complemento = enderoco.Complemento;
                end.Logradouro = enderoco.Logradouro;
                end.Numero = enderoco.Numero;
                end.Cidade = enderoco.Cidade;
                end.Uf = enderoco.Uf;
                Update(end);
                Commit();
            }
        }
    }
}
