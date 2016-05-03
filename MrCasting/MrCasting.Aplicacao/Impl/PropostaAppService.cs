using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Application.Impl
{
   public class PropostaAppService : AppServiceBase<Proposta>, IPropostaAppService
    {
        private readonly IPropostaService _service;
        IPropostaService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("PropostaService não pode ser nulo");
                return _service;
            }
        }

        public PropostaAppService(IPropostaService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarProposta(Proposta proposta)
        {
            Service.CadastrarProposta(proposta);
        }

        public IEnumerable<string> ConsultarPropostas(int idScouter)
        {
            return Service.ConsultarPropostas(idScouter);
        }

      
        public void RemoverProposta(int idProposta)
        {
            Service.RemoverProposta(idProposta);
        }

        public void EditarProposta(Proposta proposta)
        {
            throw new NotImplementedException();
        }
    }
}
