using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Domain.Interfaces.Services;
using MrCasting.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Services
{
   public class TagsService : ServiceBase<Tags>, ITagsService
    {

        private readonly ITagsRepository _repository;
        ITagsRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("TagsRepository não pode ser nulo");
                return _repository;
            }
        }

        public TagsService(ITagsRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void CadastrarTags(Tags tags)
        {
            Repository.CadastrarTags(tags);
        }

        public IEnumerable<Tags> PesquisarPorTags(string hashtag)
        {
            return Repository.PesquisarPorTags("#");
        }

        public void EditarTags(int idCandidato, List<Tags> tags)
        {
            Repository.EditarTags(idCandidato, tags);
        }
    }
}
