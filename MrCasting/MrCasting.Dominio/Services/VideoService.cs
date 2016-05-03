using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace MrCasting.Domain.Services
{
    public class VideoService : ServiceBase<VideoObj>, IVideoService
    {

        private readonly IVideoRepository _repository;
        IVideoRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("VideoRepository não pode ser nulo");
                return _repository;
            }
        }

        public VideoService(IVideoRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void CadastrarVideo(VideoObj video)
        {
            _repository.CadastrarVideo(video);
        }

        public IEnumerable<string> ConsultarVideos(int idcandidato)
        {
            return _repository.ConsultarVideos(idcandidato);
        }

        public void RemoverVideo(int idVideo)
        {
            Repository.RemoverVideo(idVideo);

        }

    }
}
