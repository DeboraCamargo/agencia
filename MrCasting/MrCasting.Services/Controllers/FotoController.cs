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
    public class FotoController : ApiController
    {
        private readonly IFotoAppService service;
        IFotoAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("FotoAppService não pode ser nulo");
                return service;
            }
        }

        public FotoController()
        {
        }

        public FotoController(IFotoAppService service)
        {
            this.service = service;
        }

        // GET: api/Foto
        public IEnumerable<FotoDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToFotoDTO());
        }

        // GET: api/Foto/5
        public FotoDTO Get(int id)
        {
            FotoObj foto = Service.GetById(id);
            if (foto == null)
                return null;
            else
                return foto.ToFotoDTO();
        }

        // POST: api/Foto
        public void Post(FotoDTO fotoDTO)
        {
            try
            {
                Service.CadastrarFoto(fotoDTO.ToFoto());
            }
            catch (CandidatoNaoEncontradoException)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // PUT: api/Foto/5
        public void Put(int id, [FromBody]FotoDTO fotoDTO)
        {
           
        }

        // DELETE: api/Foto/5
        public void Delete(int idFoto)
        {
            Service.RemoverFoto(idFoto);
        }

        [Route("api/ListarFotos/{idCandidato}")]
        [HttpGet]
        public IEnumerable<FotoDTO> ConsultarFotos(int idCandidato)
        {
            IEnumerable<FotoDTO> fotos = Service.ConsultarFotos(idCandidato).Select(f => f.ToFotoDTO());
            return fotos;
        }
    }
}
