using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Exceptions;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MrCasting.Services.Controllers
{
   public class InteresseController : ApiController
    {
        private readonly IInteresseAppService service;
        IInteresseAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("InteresseAppService não pode ser nulo");
                return service;
            }
        }

        public InteresseController() { }

        public InteresseController(IInteresseAppService service)
        {
            this.service = service;
        }

        // GET: api/Interesse
        public IEnumerable<InteresseDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToInteresseDTO());
        }

        // GET: api/Interesse/5
        public InteresseDTO Get(int id)
        {
            Interesse interesse = Service.GetById(id);
            if (interesse == null)
                return null;
            else
                return interesse.ToInteresseDTO();
        }

        // POST: api/Interesse
        public void Post(InteresseDTO interessedto)
        {
            Service.CadastrarInteresse(interessedto.ToInteresse());
        }

        // PUT: api/Interesse/5
        [Route("api/Interesse/{idCandidato:int}")]
        [HttpPut]
        public void Put(int idCandidato, InteresseDTO interesseDTO)
        {
            try
            {
                Service.EditarInteresse(idCandidato, interesseDTO.ToInteresse());
            }
            catch (CandidatoNaoEncontradoException)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Interesse/5
        public void Delete(int id)
        {
        }
    }
}