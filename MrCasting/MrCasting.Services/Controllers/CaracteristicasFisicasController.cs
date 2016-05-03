
using MrCasting.Domain.Entities;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MrCasting.Domain.Exceptions;
using System.Net;

namespace MrCasting.Services.Controllers
{
    public class CaracteristicasFisicasController : ApiController
    {

        private readonly ICaracteristicasFisicasAppService service;
        ICaracteristicasFisicasAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("CaracteristicasFisicasAppService não pode ser nulo");
                return service;
            }
        }

        public CaracteristicasFisicasController() { }
     
        public CaracteristicasFisicasController(ICaracteristicasFisicasAppService service)
        {
            this.service = service;
        }

        // GET: api/CaracteristicasFisicas
        public IEnumerable<CaracteristicasFisicasDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToCaracteristicasFisicasDTO());
        }

        // GET: api/CaracteristicasFisicas/5
        public CaracteristicasFisicasDTO Get(int id)
        {
            CaracteristicasFisicas caracteristicasFisicas = Service.GetById(id);
            if (caracteristicasFisicas == null)
                return null;
            else
                return caracteristicasFisicas.ToCaracteristicasFisicasDTO();
        }

        // POST: api/CaracteristicasFisicas
        public void Post(CaracteristicasFisicasDTO caracteristicasFisicasDTO)
        {
            Service.CadastrarCaracteristicasFisicas(caracteristicasFisicasDTO.ToCaracteristicasFisicas());
        }

        // PUT: api/CaracteristicasFisicas/5
        public void Put(int id, CaracteristicasFisicasDTO caracteristicaFisicaDTO)
        {
            try
            {
                Service.EditarCaracteristicaFisica(id, caracteristicaFisicaDTO.ToCaracteristicasFisicas());
            }
            catch (CandidatoNaoEncontradoException)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

        }

        // DELETE: api/CaracteristicasFisicas/5
        public void Delete(int id)
        {
        }

    }
}
