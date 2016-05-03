using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Repositories
{
   public interface IScouterRepository : IRepository<Scouter>
    {
        void CadastrarScouter(Scouter scouter);
        void EditarScouter(int idScouter, Scouter scouter);
        IEnumerable<Scouter> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais);
    }
}
