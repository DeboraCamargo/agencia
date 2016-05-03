using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Services
{
    public interface IVideoService : IServiceBase<VideoObj>
    {
        void CadastrarVideo(VideoObj video);
        IEnumerable<string> ConsultarVideos(int idcandidato);
        void RemoverVideo(int idVideo);
    }
}
