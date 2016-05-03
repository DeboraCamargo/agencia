using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Services
{
    public interface IContaService : IServiceBase<Conta>
    {
        Conta GetByLogin(LoginOAuth _login);
        void CadastrarConta(Conta conta);
        Conta GetByIdLogin(int idLogin);
    }
}
