using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Services
{
    public interface ILoginOAuthService : IServiceBase<LoginOAuth>
    {
        bool LoginIsValid(LoginOAuth login);
        void CadastrarLogin(LoginOAuth login);
        Conta Logar(LoginOAuth login);
        void Logout(LoginOAuth login);

    }
}
