using MrCasting.Domain.Entities;
using MrCasting.Domain.Exceptions;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Infra.Data.Repositories
{
   public class VideoRepository : RepositoryBase<VideoObj>, IVideoRepository
    {

        protected readonly DbSet<VideoObj> VideoDb;
        protected readonly DbSet<Candidato> CandidatoDb;
        private readonly CandidatoRepository candidatoRepository;

        public VideoRepository(GeneralContext context) : base(context)
        {
            VideoDb = context.Video;
            CandidatoDb = context.Candidatos;
            candidatoRepository = new CandidatoRepository(context);
        }

        public void CadastrarVideo(VideoObj video)
        {
            VideoDb.Add(video);
            Commit();
        }

        public IEnumerable<string> ConsultarVideos(int idcandidato)
        {

            throw new NotImplementedException();

        }

        public void EditarVideo(int idCandidato, List<VideoObj> videos)
        {
            Candidato candidato = CandidatoDb.Where(c => c.Id == idCandidato).Include("AlbumVideos").FirstOrDefault();
            if (candidato == null)
                throw new CandidatoNaoEncontradoException();

            List<VideoObj> listaVideos = candidato.AlbumVideos.ToList();
            candidato.AlbumVideos.RemoveAll(v => true);

            DeleteAll(listaVideos);
            Commit();

            candidato.AlbumVideos.AddRange(videos);
            candidatoRepository.Update(candidato); // É algo assim
            candidatoRepository.Commit();
           
        }

        public void RemoverVideo(int idVideo)
        {
            throw new NotImplementedException();
        }
    }
}
