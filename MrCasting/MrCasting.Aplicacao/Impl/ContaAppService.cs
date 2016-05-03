using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Application.Impl
{
   public class ContaAppService: AppServiceBase<Conta>, IContaAppService
    {
        private readonly IContaService _service;
        IContaService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("ContaService não pode ser nulo");
                return _service;
            }
        }

        public ContaAppService(IContaService service) : base(service)
        {
            _service = service;
        }

        public Conta GetByLogin(LoginOAuth _login)
        {
            return Service.GetByLogin(_login);
        }

        public void CadastrarConta(Conta conta)
        {
            Service.CadastrarConta(conta);
        }

        public Conta GetByIdLogin(int idLogin)
        {
            return Service.GetByIdLogin(idLogin);
        }
    }
}
