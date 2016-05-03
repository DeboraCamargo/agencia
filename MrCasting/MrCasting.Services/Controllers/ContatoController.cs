using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
using MrCasting.Domain.DTO;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Exceptions;
using System.Net;

namespace MrCasting.Services.Impl
{
    public class ContatoController : ApiController
    {
        private readonly IContatoAppService service;
        IContatoAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("ContatoAppService não pode ser nulo");
                return service;
            }
        }

        public ContatoController()
        {
        }

        public ContatoController(IContatoAppService service)
        {
            this.service = service;
        }

        // GET: api/Contato
        public IEnumerable<ContatoDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToContatoDTO());
        }

        // GET: api/Contato/5
        public ContatoDTO Get(int id)
        {
            Contato contato = Service.GetById(id);
            if (contato == null)
                return null;
            else 
            return contato.ToContatoDTO();
        }

        // POST: api/Contato
        public void Post(ContatoDTO contato)
        {
            Service.Add(contato.ToContato());
        }

        // PUT: api/Contato/5
        public void Put(int id, ContatoDTO contatoDTO)
        {
            try
            {
                Service.Editar(id, contatoDTO.ToContato());
            }
            catch (CandidatoNaoEncontradoException)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Contato/5
        public void Delete(int id)
        {
            //throw new HttpResponseException(HttpStatusCode.MethodNotAllowed);
        }
    }
}
