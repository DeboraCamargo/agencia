using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MrCasting.Services.Controllers
{
    public class PropostaController : ApiController
    {
        private readonly IPropostaAppService service;
        IPropostaAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("PropostaAppService não pode ser nulo");
                return service;
            }
        }

        public PropostaController()
        {
        }

        public PropostaController(IPropostaAppService service)
        {
            this.service = service;
        }

        // GET: api/Proposta
        public IEnumerable<PropostaDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToPropostaDTO());
        }

        // GET: api/Proposta/5
        public PropostaDTO Get(int id)
        {
            Proposta proposta = Service.GetById(id);
            if (proposta == null)
                return null;
            else
                return proposta.ToPropostaDTO();
        }

        // POST: api/Proposta
        public void Post(PropostaDTO PropostaDTO)
        {
            Service.CadastrarProposta(PropostaDTO.ToProposta());
        }

        // PUT: api/Proposta/5
        public void Put([FromBody]PropostaDTO proposta)
        {
            Service.EditarProposta(proposta.ToProposta());
        }

        // DELETE: api/Proposta/5
        public void Delete(int idProposta)
        {
            Service.RemoverProposta(idProposta);
        }

        [Route("api/PesquisaProposta/DadosInfo")]
        [HttpPost]
        public IEnumerable<string> ConsultarPropostas(int idCandidato)
        {
            IEnumerable<string> Propostas = Service.ConsultarPropostas(idCandidato);
            return Propostas;
        }
    }
}
