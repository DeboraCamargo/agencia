using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;

namespace MrCasting.Application.Impl
{
    public class ContatoAppService : AppServiceBase<Contato>, IContatoAppService
    {
        private readonly IContatoService _service;
        IContatoService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("ContatoService não pode ser nulo");
                return _service;
            }
        }

        public ContatoAppService(IContatoService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarContato(Contato Contato)
        {
            Service.Add(Contato);
        }

        public void Editar(int id, Contato contato)
        {
            Service.Editar(id, contato);
        }
    }
}
