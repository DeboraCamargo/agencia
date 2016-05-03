using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Services
{
    public interface ICaracteristicaFisicaService : IServiceBase<CaracteristicasFisicas>
    {
        void CadastrarCaracteristicasFisicas(CaracteristicasFisicas caracteristicasFisicas);
        void EditarCaracteristicaFisica(int IdCandidato, CaracteristicasFisicas caracteristicasFisicas);
    }
}
