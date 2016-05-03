using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MrCasting.Services.Controllers
{
    public class VagaController : ApiController
    {


        private readonly IVagaAppService service;
        IVagaAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("VagaAppService não pode ser nulo");
                return service;
            }
        }

        public VagaController()
        {
        }

        public VagaController(IVagaAppService service)
        {
            this.service = service;
        }

        // GET: api/Vaga
        public IEnumerable<VagaDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToVagaDTO());
        }

        // GET: api/Vaga/5
        public VagaDTO Get(int id)
        {
            Vaga vaga = Service.GetById(id);
            if (vaga == null)
                return null;
            else
                return vaga.ToVagaDTO();
        }

        // POST: api/Vaga
        public void Post(VagaDTO VagaDTO)
        {
            Service.CadastrarVaga(VagaDTO.ToVaga());
        }

        // PUT: api/Vaga/5
        public void Put(int id,[FromBody]VagaDTO vaga)
        {
            Service.EditarVaga(id,vaga.ToVaga());
        }

        // DELETE: api/Vaga/5
        public void Delete(int idVaga)
        {
            Service.RemoverVaga(idVaga);
        }

        [Route("api/PesquisaVaga/DadosInfo")]
        [HttpPost]
        public IEnumerable<string> ConsultarVagas(int idVaga)
        {
            IEnumerable<string> Vagas = Service.ConsultarVagas(idVaga);
            return Vagas;
        }


        [Route("api/PesquisaVagaPorScouter/DadosInfo")]
        [HttpPost]
        public IEnumerable<string> ConsultarVagasPorScouter(int idScouter)
        {
            IEnumerable<string> Vagas = Service.ConsultarTodasVagasPorScouter(idScouter);
            return Vagas;
        }

    }
}