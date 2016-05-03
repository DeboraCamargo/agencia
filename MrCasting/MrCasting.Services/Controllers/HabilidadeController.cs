using MrCasting.Domain.Entities;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using MrCasting.Domain.Exceptions;
using System.Net;

namespace MrCasting.Services.Controllers
{
    public class HabilidadeController: ApiController
    {
        private readonly IHabilidadeAppService service;
        IHabilidadeAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("HabilidadeAppService não pode ser nulo");
                return service;
            }
        }

        public HabilidadeController() { }

        public HabilidadeController(IHabilidadeAppService service)
        {
            this.service = service;
        }

        // GET: api/Habilidade
        public IEnumerable<HabilidadeDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToHabilidadeDTO());
        }

        // GET: api/Habilidade/5
        public HabilidadeDTO Get(int id)
        {
            Habilidade habilidade = Service.GetById(id);
            if (habilidade == null)
                return null;
            else
                return habilidade.ToHabilidadeDTO();
        }

        // POST: api/Habilidade
        public void Post(HabilidadeDTO habilidadeDTO)
        {
            Service.CadastrarHabilidade(habilidadeDTO.ToHabilidade());
        }

        // PUT: api/Habilidade/5
        public void Put(int id, List<HabilidadeDTO> habilidadeListDTO)
        {
            try
            {
                Service.EditarHabilidade(id, habilidadeListDTO.Select(h => h.ToHabilidade()).ToList());
            }
            catch (CandidatoNaoEncontradoException)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Habilidade/5
        public void Delete(int id)
        {
        }
    }
}