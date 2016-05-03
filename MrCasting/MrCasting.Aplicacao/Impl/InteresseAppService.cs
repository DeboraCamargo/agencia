using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;

namespace MrCasting.Application.Impl
{
    public class InteresseAppService : AppServiceBase<Interesse>, IInteresseAppService
    {

        private readonly IInteresseService _service;
        IInteresseService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("InteresseService não pode ser nulo");
                return _service;
            }
        }

        public InteresseAppService(IInteresseService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarInteresse(Interesse interesse)
        {
            Service.CadastrarInteresse(interesse);
        }

        public void EditarInteresse(int IdCandidato, Interesse interesse)
        {
            Service.EditarInteresse(IdCandidato, interesse);
        }
    }
}
