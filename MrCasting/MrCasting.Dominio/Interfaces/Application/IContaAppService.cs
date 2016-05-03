using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Application
{
    public  interface IContaAppService: IAppServiceBase<Conta>
    {
        Conta GetByLogin(LoginOAuth _login);
        Conta GetByIdLogin(int idLogin);
        void CadastrarConta(Conta conta);
    }
}
