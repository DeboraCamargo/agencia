using MrCasting.Domain.Entities;
using MrCasting.Domain.Exceptions;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Domain.ValueObject;
using MrCasting.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Infra.Data.Repositories
{
   public class TagRepository : RepositoryBase<Tags>, ITagsRepository
    {

        private readonly DbSet<Tags> TagsDb;
        protected readonly DbSet<Candidato> CandidatoDb;
        private readonly CandidatoRepository candidatoRepository;

        public TagRepository(GeneralContext context) : base(context)
        {
            TagsDb = context.Tags;
            CandidatoDb = context.Candidatos;
            candidatoRepository = new CandidatoRepository(context);
        }

        public void CadastrarTags(Tags tags)
        {
            throw new NotImplementedException();
        }

        public void EditarTags(int idCandidato, List<Tags> tags)
        {
            Candidato candidato = CandidatoDb.Where(c => c.Id == idCandidato).Include("Tags").FirstOrDefault();
            if (candidato == null)
                throw new CandidatoNaoEncontradoException();

            List<Tags> tag = candidato.Tags.ToList();
            candidato.Tags.RemoveAll(h => true);

            DeleteAll(tag);
            Commit();

            candidato.Tags.AddRange(tags);
            candidatoRepository.Update(candidato); 
            candidatoRepository.Commit();
        }

        public IEnumerable<Tags> PesquisarPorTags(string hashtag)
        {
            throw new NotImplementedException();
        }
    }
}
