using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Application
{
    public interface IVideoAppService : IAppServiceBase<VideoObj>
    {
        void CadastrarVideo(VideoObj video);
        IEnumerable<string> ConsultarVideos(int idcandidato);
        void RemoverVideo(int idVideo);
    }
}
