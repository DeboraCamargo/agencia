using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Application
{
    public interface IHabilidadeAppService:IAppServiceBase<Habilidade>
    {
        void CadastrarHabilidade(Habilidade habilidade);
        void EditarHabilidade(int idCandidato, List<Habilidade> habilidades);

    }
}
