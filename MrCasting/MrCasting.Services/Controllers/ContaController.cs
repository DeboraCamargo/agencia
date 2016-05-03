using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MrCasting.Services.Controllers
{
    public class ContaController : ApiController
    {
        private readonly IContaAppService service;
        IContaAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("ContaAppService não pode ser nulo");
                return service;
            }
        }

        public ContaController()
        {
        }

        public ContaController(IContaAppService service)
        {
            this.service = service;
        }

        // GET: api/Conta
        public IEnumerable<ContaDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToContaDTO());
        }

        // GET: api/Conta/5
        public ContaDTO Get(int idLogin)
        {
            Conta conta = Service.GetById(idLogin);
            if (conta == null)
                return null;
            else
                return conta.ToContaDTO();
        }

        // POST: api/Conta
        public void Post(ContaDTO ContaDTO)
        {
            Service.CadastrarConta(ContaDTO.ToConta());
        }

    }
}
