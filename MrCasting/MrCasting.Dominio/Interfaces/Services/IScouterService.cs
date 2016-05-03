using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Services
{
   public interface IScouterService : IServiceBase<Scouter>
    {
        void EditarScouter(int idScouter, Scouter scouter);
        void CadastrarScouter(Scouter scouter);
        IEnumerable<Scouter> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais);
    }
}
