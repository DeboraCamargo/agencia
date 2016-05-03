using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Application.Impl
{
    public class VideoAppService : AppServiceBase<VideoObj>, IVideoAppService
    {

        private readonly IVideoService _service;
        IVideoService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("VideoService não pode ser nulo");
                return _service;
            }
        }

        public VideoAppService(IVideoService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarVideo(VideoObj video)
        {
            Service.CadastrarVideo(video);
        }

        public IEnumerable<string> ConsultarVideos(int idcandidato)
        {
            return Service.ConsultarVideos(idcandidato);
        }

        public void RemoverVideo(int idVideo)
        {
            Service.RemoverVideo(idVideo);
        }
    }
}
