using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Domain.Interfaces.Services;
using System;

namespace MrCasting.Domain.Services
{
    public class CaracteristicaFisicaService : ServiceBase<CaracteristicasFisicas>, ICaracteristicaFisicaService
    {

        private readonly ICaracteristicaFisicaRepository _repository;
        ICaracteristicaFisicaRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("Caracteristica Fisica AppService não pode ser nulo");
                return _repository;
            }
        }

        public CaracteristicaFisicaService(ICaracteristicaFisicaRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void CadastrarCaracteristicasFisicas(CaracteristicasFisicas caracteristicasFisicas)
        {
            Repository.CadastrarCaracteristicasFisicas(caracteristicasFisicas);
        }

        public void EditarCaracteristicaFisica(int IdCandidato, CaracteristicasFisicas caracteristicasFisicas)
        {
            Repository.EditarCaracteristicaFisica(IdCandidato, caracteristicasFisicas);
        }
    }
}
