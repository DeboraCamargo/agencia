using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Application
{
    public interface ICaracteristicasFisicasAppService : IAppServiceBase<CaracteristicasFisicas>
    {
        void CadastrarCaracteristicasFisicas(CaracteristicasFisicas caracteristicasFisicas);
        void EditarCaracteristicaFisica(int IdCandidato, CaracteristicasFisicas caracteristicasFisicas);


    }
}
