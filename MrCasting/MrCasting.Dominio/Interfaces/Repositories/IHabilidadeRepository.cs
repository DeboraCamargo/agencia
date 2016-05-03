using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface IHabilidadeRepository : IRepository<Habilidade>
    {
        void CadastrarHabilidade(Habilidade habilidade);
        void EditarHabilidade(int idCandidato, List<Habilidade> habilidades);
    }
}
