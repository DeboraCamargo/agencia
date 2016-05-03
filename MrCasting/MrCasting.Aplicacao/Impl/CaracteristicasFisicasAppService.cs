using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;

namespace MrCasting.Application.Impl
{
    public class CaracteristicasFisicasAppService : AppServiceBase<CaracteristicasFisicas>, ICaracteristicasFisicasAppService
    {
        private readonly ICaracteristicaFisicaService _service;
        ICaracteristicaFisicaService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("CaracteristicaFisicaService não pode ser nulo");
                return _service;
            }
        }

        public CaracteristicasFisicasAppService(ICaracteristicaFisicaService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarCaracteristicasFisicas(CaracteristicasFisicas caracteristicasFisicas)
        {
            Service.CadastrarCaracteristicasFisicas(caracteristicasFisicas);
        }

        public void EditarCaracteristicaFisica(int IdCandidato, CaracteristicasFisicas caracteristicasFisicas)
        {
            Service.EditarCaracteristicaFisica(IdCandidato, caracteristicasFisicas);
        }
    }
}
