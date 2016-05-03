using MrCasting.Domain.Entities;
using MrCasting.Domain.Exceptions;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Infra.Data.Repositories
{
    public class PropostaRepository : RepositoryBase<Proposta>, IPropostaRepository
    {

        protected readonly DbSet<Proposta> PropostaDb;
        private readonly VagaRepository vagaRepository;

        public PropostaRepository(GeneralContext context) : base(context)
        {
            PropostaDb = context.Proposta;
            vagaRepository = new VagaRepository(context);
        }

        public void CadastrarProposta(Proposta proposta)
        {
            PropostaDb.Add(proposta);
            Commit();

        }

        public IEnumerable<string> ConsultarPropostas(int idScouter)
        {
            throw new NotImplementedException();
        }

        public void EditarProposta(int idProposta, Proposta proposta)
        {
            Proposta prop = PropostaDb.Where(c => c.Id == idProposta).FirstOrDefault();

            if (prop == null)
            {
                throw new PropostaNaoEncontradaException();
            }

            prop.Cache = proposta.Cache;
            prop.DataEntrevista = proposta.DataEntrevista;
            prop.DataExpiraProposta = proposta.DataExpiraProposta;
            prop.DataFimJob = proposta.DataFimJob;
            prop.DataIncioJob = proposta.DataIncioJob;
            prop.DetalhesProposta = proposta.DetalhesProposta;
            prop.NaoTemFinalDataDefinida = proposta.NaoTemFinalDataDefinida;
            prop.Status = proposta.Status;
            Update(prop);
            Commit();
        }

        public void RemoverProposta(int idProposta)
        {
            throw new NotImplementedException();
        }


    }
}
