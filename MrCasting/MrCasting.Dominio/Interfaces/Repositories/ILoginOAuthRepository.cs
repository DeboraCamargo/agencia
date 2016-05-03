using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface ILoginOAuthRepository: IRepository<LoginOAuth>
    {
        bool LoginIsValid(LoginOAuth login);
        void CadastrarLogin(LoginOAuth login);
        Conta Logar(LoginOAuth login);
        void Logout(LoginOAuth login);

    }
}
