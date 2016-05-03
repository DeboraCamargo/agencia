using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Application
{
    public interface ILoginOAuthAppService: IAppServiceBase<LoginOAuth>
    {
        bool LoginIsValid(LoginOAuth login);
        void CadastrarLogin(LoginOAuth login);
        Conta Logar(LoginOAuth login);
        void Logout(LoginOAuth login);
    }
}
