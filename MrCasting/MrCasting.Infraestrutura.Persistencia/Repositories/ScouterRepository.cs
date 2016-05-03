using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrCasting.Domain.DTO;
using MrCasting.Domain.Exceptions;

namespace MrCasting.Infra.Data.Repositories
{
  public  class ScouterRepository : RepositoryBase<Scouter>, IScouterRepository
    {

        protected readonly DbSet<Scouter> ScouterDb;
        private readonly PessoaRepository pessoaRepository;

        public ScouterRepository(GeneralContext context) : base(context)
        {
            ScouterDb = context.Scouter;
            pessoaRepository = new PessoaRepository(context);
        }

        public void CadastrarScouter(Scouter scouter)
        {
            Add(scouter);
            Commit();
        }

        public void EditarScouter(int idScouter, Scouter scouter)
        {
            Scouter sco = ScouterDb.Where(c => c.Id == idScouter).FirstOrDefault();
            if (sco == null)
                throw new ScouterNaoEncontradoException();
            sco.Agencia = scouter.Agencia;
            sco.Cnpj = scouter.Cnpj;
            Update(sco);
            Commit();
        }

        public IEnumerable<Scouter> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais)
        {
            throw new NotImplementedException();
        }
    }
}
