using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Application
{
   public interface IScouterAppService : IAppServiceBase<Scouter>
    {
        void CadastrarScouter(Scouter scouter);
        void EditarScouter(int idScouter, Scouter scouter);
        IEnumerable<Scouter> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais);

    }
}
