using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Services
{
     public interface IHabilidadeService : IServiceBase<Habilidade>
    {
        void EditarHabilidade(int idCandidato, List<Habilidade> habilidades);
        void CadastrarHabilidade(Habilidade habilidade);

    }
}
