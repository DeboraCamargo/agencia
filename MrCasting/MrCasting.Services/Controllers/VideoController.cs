using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Exceptions;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace MrCasting.Services.Controllers
{
    public class VideoController : ApiController
    {

        private readonly IVideoAppService service;
        IVideoAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("VideoAppService não pode ser nulo");
                return service;
            }
        }

        public VideoController()
        {
        }

        public VideoController(IVideoAppService service)
        {
            this.service = service;
        }

        // GET: api/Video
        public IEnumerable<VideoDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToVideoDTO());
        }

        // GET: api/Video/5
        public VideoDTO Get(int id)
        {
            VideoObj Video = Service.GetById(id);
            if (Video == null)
                return null;
            else
                return Video.ToVideoDTO();
        }

        // POST: api/Video
        public void Post(VideoDTO VideoDTO)
        {
            Service.CadastrarVideo(VideoDTO.ToVideo());
        }

        // DELETE: api/Video/5
        public void Delete(int idVideo)
        {
            Service.RemoverVideo(idVideo);
        }

        [Route("api/PesquisaVideo/DadosInfo")]
        [HttpPost]
        public IEnumerable<string> ConsultarVideos(int idCandidato)
        {
            IEnumerable<string> Videos = Service.ConsultarVideos(idCandidato);
            return Videos;
        }
    }
}
