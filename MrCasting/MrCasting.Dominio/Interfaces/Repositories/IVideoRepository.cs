using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface IVideoRepository : IRepository<VideoObj>
    {
        void CadastrarVideo(VideoObj video);
        IEnumerable<string> ConsultarVideos(int idcandidato);
        void RemoverVideo(int idVideo);
    }
}
