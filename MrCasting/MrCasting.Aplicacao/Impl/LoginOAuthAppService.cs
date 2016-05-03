using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;

namespace MrCasting.Application.Impl
{
    public class LoginOAuthAppService: AppServiceBase<LoginOAuth>, ILoginOAuthAppService
    {
        private readonly ILoginOAuthService _service;
        ILoginOAuthService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("FotoService não pode ser nulo");
                return _service;
            }
        }

        public LoginOAuthAppService(ILoginOAuthService service) : base(service)
        {
            _service = service;
        }

        public bool LoginIsValid(LoginOAuth login)
        {
            return Service.LoginIsValid(login);
        }

        public void CadastrarLogin(LoginOAuth login)
        {
            Service.CadastrarLogin(login);
        }

        public Conta Logar(LoginOAuth login)
        {
            return Service.Logar(login);
        }

        public void Logout(LoginOAuth login)
        {
            Service.Logout(login);
        }

   
    }
}
