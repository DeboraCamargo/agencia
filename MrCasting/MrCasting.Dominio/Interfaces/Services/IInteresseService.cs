using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Services
{
    public interface IInteresseService : IServiceBase<Interesse>
    {
        void CadastrarInteresse(Interesse interesse);
        void EditarInteresse(int IdCandidato, Interesse interesse);
        IEnumerable<Interesse> PesquisarPorInteresse(Interesse interesse);

    }
}
