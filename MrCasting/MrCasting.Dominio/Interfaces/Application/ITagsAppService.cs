using MrCasting.Domain.ValueObject;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Application
{
    public interface ITagsAppService : IAppServiceBase<Tags>
    {
        void CadastrarTags(Tags tags);
        void EditarTags(int idCandidato, List<Tags> tags);
    }
}
