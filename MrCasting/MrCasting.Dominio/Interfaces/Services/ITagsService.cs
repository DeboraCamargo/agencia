using MrCasting.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Services
{
   public interface ITagsService : IServiceBase<Tags>
    {
        void CadastrarTags(Tags tags);
        IEnumerable<Tags> PesquisarPorTags(string hashtag);
        void EditarTags(int idCandidato, List<Tags> tags);

    }
}
