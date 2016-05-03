using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface ICaracteristicaFisicaRepository : IRepository<CaracteristicasFisicas>
    {
        void CadastrarCaracteristicasFisicas(CaracteristicasFisicas caracteristicasFisicas);
        void EditarCaracteristicaFisica(int IdCandidato, CaracteristicasFisicas caracteristicasFisicas);

    }
}
