using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace MrCasting.Application.Impl
{
  public class HobbyAppService : AppServiceBase<Hobby>, IHobbyAppService
    {
        private readonly IHobbyService _service;
        IHobbyService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("HobbyService não pode ser nulo");
                return _service;
            }
        }

        public HobbyAppService(IHobbyService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarHobby(Hobby hobby)
        {
            Service.CadastrarHobby(hobby);
        }

        public void EditarHobby(int idCandidato, List<Hobby> hobby)
        {
            Service.EditarHobby(idCandidato, hobby);
        }
    }
}
