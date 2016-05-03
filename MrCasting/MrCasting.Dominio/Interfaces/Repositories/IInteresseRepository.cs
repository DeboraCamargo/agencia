using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface IInteresseRepository : IRepository<Interesse>
    {
        void CadastrarInteresse(Interesse interesse);
        void EditarInteresse(int IdCandidato, Interesse interesse);

    }
}
