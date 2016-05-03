using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
using MrCasting.Domain.DTO;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using System.Net;
using MrCasting.Domain.Exceptions;
using MrCasting.Domain.DTO.Pesquisas;

namespace MrCasting.Services.Controllers
{
    public class CandidatoController : ApiController
    {
        private readonly ICandidatoAppService service;
        ICandidatoAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("CandidatoAppService não pode ser nulo");
                return service;
            }
        }

        public CandidatoController()
        {
        }

        public CandidatoController(ICandidatoAppService service)
        {
            this.service = service;
        }

        // GET: api/Candidato
        public IEnumerable<CandidatoDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToCandidatoDTO());
        }

        // GET: api/Candidato/5
        public CandidatoDTO Get(int id)
        {
            Candidato candidato = Service.GetById(id);
            if (candidato == null)
                return null;
            else 
            return candidato.ToCandidatoDTO();
        }

        // POST: api/Candidato
        public void Post(CandidatoDTO candidatoDTO)
        {
            try
            {
                Service.CadastrarCandidato(candidatoDTO.ToCandidato());
            }
            catch(Exception)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            
        }

        // PUT: api/Candidato/5
        public void Put(int id, CandidatoDTO candidatodto)
        {
            try
            {
                Service.EditarCandidato(id, candidatodto.ToCandidato());
            }
            catch (CandidatoNaoEncontradoException)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

        }

        // DELETE: api/Candidato/5
        public void Delete(int id)
        {
        }

        [Route("api/PesquisaCandidato/DadosInfo")]
        [HttpPost]
        public IEnumerable<CandidatoDTO> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais)
        {
            IEnumerable<Candidato> candidatos = Service.PesquisarPorDadosPessoais(pesquisaDadosPessoais);
            return candidatos.Select(c => c.ToCandidatoDTO());
        }

        [Route("api/Candidato/Pesquisar")]
        [HttpPost]
        public IEnumerable<CandidatoDTO> PesquisarPorDadosPessoais(PesquisaCandidatoDTO pesquisaDadosPessoais)
        {
            IEnumerable<Candidato> candidatos = Service.PesquisarCompleta(pesquisaDadosPessoais);
            return candidatos.Select(c => c.ToCandidatoDTO());
        }
    }
}
