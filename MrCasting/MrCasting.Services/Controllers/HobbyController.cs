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
   public class HobbyController: ApiController
    {

        private readonly IHobbyAppService service;
        IHobbyAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("HobbyAppService não pode ser nulo");
                return service;
            }
        }

        public HobbyController() { }

        public HobbyController(IHobbyAppService service)
        {
            this.service = service;
        }

        // GET: api/Candidato
        public IEnumerable<HobbyDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToHobbyDTO());
        }

        // GET: api/Candidato/5
        public HobbyDTO Get(int id)
        {
            Hobby hobby = Service.GetById(id);
            if (hobby == null)
                return null;
            else
                return hobby.ToHobbyDTO();
        }

        // POST: api/Candidato
        public void Post(HobbyDTO hobbyDTO)
        {
            Service.CadastrarHobby(hobbyDTO.ToHobby());
        }

        // PUT: api/Candidato/5
        public void Put(int id, List<HobbyDTO> hobbyListDTO)
        {
            try
            {
                Service.EditarHobby(id, hobbyListDTO.Select(h => h.ToHobby()).ToList());
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
    }
}