using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.DTO;
using MrCasting.Domain.ValueObject;
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
    public class TagsController : ApiController
    {
        private readonly ITagsAppService service;
        ITagsAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("TagsAppService não pode ser nulo");
                return service;
            }
        }

        public TagsController() { }

        public TagsController(ITagsAppService service)
        {
            this.service = service;
        }

        // GET: api/Tags
        public IEnumerable<TagsDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToTagsDTO());
        }

        // GET: api/Tags/5
        public TagsDTO Get(int id)
        {
            Tags tags = Service.GetById(id);
            if (tags == null)
                return null;
            else
                return tags.ToTagsDTO();
        }

        // POST: api/Tags
        public void Post(TagsDTO tagsDTO)
        {
            Service.CadastrarTags(tagsDTO.ToTags());
        }

        // PUT: api/Tags/5
        [Route("api/Tags/{idCandidato:int}")]
        [HttpPut]
        public void Put(int idCandidato, List<TagsDTO> value)
        {
            try
            {
                Service.EditarTags(idCandidato, value.Select(t => t.ToTags()).ToList());
            }
            catch (CandidatoNaoEncontradoException)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Tags/5
        public void Delete(int id)
        {
        }
    }
}