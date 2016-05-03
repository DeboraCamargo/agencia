using System;
using System.Linq;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System.Data.Entity;
using MrCasting.Domain.Exceptions;

namespace MrCasting.Infra.Data.Repositories
{
    public class LoginOAuthRepository : RepositoryBase<LoginOAuth>, ILoginOAuthRepository
    {

        protected readonly DbSet<LoginOAuth> LoginOAuthDb;
        private readonly ContaRepository ContaRepository;

        public LoginOAuthRepository(GeneralContext context) : base(context)
        {
            LoginOAuthDb = context.LoginOAuth;

            ContaRepository = new ContaRepository(context);
        }

        public void CadastrarLogin(LoginOAuth login)
        {
            Add(login);
        }

        public Conta Logar(LoginOAuth login)
        {
            LoginOAuth _login = LoginOAuthDb.Where(l => l.Email.Equals(login.Email.ToLower())).FirstOrDefault();
            if (_login == null)
                throw new UsuarioNaoCadastradoException();
            _login.Token = login.Token;
            Update(_login);
            Commit();
            return ContaRepository.GetByLogin(_login);
        }

        public bool LoginIsValid(LoginOAuth login)
        {
            LoginOAuth _login = LoginOAuthDb.Where(l => l.Email.Equals(login.Email.ToLower())).FirstOrDefault();
            return isSameLogin(login, _login);
        }

        private bool isSameLogin(LoginOAuth login, LoginOAuth _login)
        {
            if (login == null || string.IsNullOrEmpty(_login.Token))
                return false;
            return _login.Id == login.Id && _login.Token.Equals(login.Token);

        }

        public void Logout(LoginOAuth login)
        {
            LoginOAuth _login = LoginOAuthDb.Where(l => l.Email.Equals(login.Email.ToLower())).FirstOrDefault();
            if (isSameLogin(login, _login))
            {
                _login.Token = null;
                Update(_login);
            }
            else
            {
                throw new Exception("Não foi possivel realizar login para este login");
            }


        }
    }
}
