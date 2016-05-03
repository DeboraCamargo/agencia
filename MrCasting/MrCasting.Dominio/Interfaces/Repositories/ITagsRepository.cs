using MrCasting.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface ITagsRepository : IRepository<Tags>
    {
        void CadastrarTags(Tags tags);
        void EditarTags(int idCandidato, List<Tags> tags);
        IEnumerable<Tags> PesquisarPorTags(string hashtag);

    }
}
