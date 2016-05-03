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
   public class EnderecoController : ApiController
    {
        private readonly IEnderecoAppService service;
        IEnderecoAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("EnderecoAppService não pode ser nulo");
                return service;
            }
        }

        public EnderecoController()
        {
        }

        public EnderecoController(IEnderecoAppService service)
        {
            this.service = service;
        }

        // GET: api/Endereco
        public IEnumerable<EnderecoDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToEnderecoDTO());
        }

        // GET: api/Endereco/5
        public EnderecoDTO Get(int id)
        {
            Endereco endereco = Service.GetById(id);
            if (endereco == null)
                return null;
            else
                return endereco.ToEnderecoDTO();
        }

        // POST: api/Endereco
        public void Post(EnderecoDTO enderecodto)
        {
            Service.Add(enderecodto.ToEndereco());
        }

        // PUT: api/Endereco/5
        public void Put(int id, EnderecoDTO enderecoDTO)
        {
            try
            {
                Service.EditarEndereco(id, enderecoDTO.ToEndereco());
            }
            catch (CandidatoNaoEncontradoException)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Endereco/5
        public void Delete(int id)
        {
        }
    }
}

