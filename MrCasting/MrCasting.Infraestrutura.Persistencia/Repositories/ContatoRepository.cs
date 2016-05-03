using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System.Data.Entity;
using System.Linq;

namespace MrCasting.Infra.Data.Repositories
{
    public class ContatoRepository : RepositoryBase<Contato>, IContatoRepository
    {
        protected readonly DbSet<Contato> ContatoDb;
        protected readonly DbSet<Pessoa> PessoaDb;
        private readonly PessoaRepository pessoaRepository;

        public ContatoRepository(GeneralContext context) : base(context)
        {
            ContatoDb = context.Contatos;
            PessoaDb = context.Pessoas;
            pessoaRepository = new PessoaRepository(context);
        }

        public void CadastrarContato(Contato contato)
        {
            Add(contato);
            Commit();
        }

        public void Editar(int idPessoa, Contato contato)
        {
            int idContato = PessoaDb.Where(c => c.Id == idPessoa).Select(c => c.Contato.Id).FirstOrDefault();
            if(idContato != 0)
            {
                contato.Id = idContato;
                Update(contato);
                Commit();
            }
        }
    }
}
