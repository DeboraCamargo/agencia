using System;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Services;
using MrCasting.Domain.Interfaces.Repositories;

namespace MrCasting.Domain.Services
{
    public class LoginOAuthService : ServiceBase<LoginOAuth>, ILoginOAuthService
    {

        private readonly ILoginOAuthRepository _repository;
        ILoginOAuthRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("LoginOAuthRepository não pode ser nulo");
                return _repository;
            }
        }

        public LoginOAuthService(ILoginOAuthRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void CadastrarLogin(LoginOAuth login)
        {
            Repository.CadastrarLogin(login);
        }

        public Conta Logar(LoginOAuth login)
        {
            return Repository.Logar(login);
        }

        public bool LoginIsValid(LoginOAuth login)
        {
            return Repository.LoginIsValid(login);
        }

        public void Logout(LoginOAuth login)
        {
            Repository.Logout(login);
        }
    }
}
