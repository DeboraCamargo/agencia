using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Services
{
    public class PropostaService : ServiceBase<Proposta>, IPropostaService
    {

        private readonly IPropostaRepository _repository;
        IPropostaRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("PropostaRepository não pode ser nulo");
                return _repository;
            }
        }

        public PropostaService(IPropostaRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void CadastrarProposta(Proposta proposta)
        {
            Repository.CadastrarProposta(proposta);
        }

        public IEnumerable<string> ConsultarPropostas(int idScouter)
        {
            return Repository.ConsultarPropostas(idScouter);
        }


        public void RemoverProposta(int idProposta)
        {
            Repository.RemoverProposta(idProposta);
        }

        public void EditarProposta(int idProposta,Proposta proposta)
        {
            Repository.EditarProposta(idProposta,proposta);
        }
    }
}
