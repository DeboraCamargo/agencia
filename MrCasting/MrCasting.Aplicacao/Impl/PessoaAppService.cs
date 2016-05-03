using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;

namespace MrCasting.Application.Impl
{
    public class PessoaAppService : AppServiceBase<Pessoa>, IPessoaAppService
    {

        private readonly IPessoaService _service;
        IPessoaService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("PessoaService não pode ser nulo");
                return _service;
            }
        }

        public PessoaAppService(IPessoaService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            Service.CadastrarPessoa(pessoa);
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            Service.AtualizarPessoa(pessoa);
        }
    }
}
