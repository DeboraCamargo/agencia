using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface IContaRepository: IRepository<Conta>
    {
        Conta GetByLogin(LoginOAuth _login);
        void CadastrarConta(Conta conta);
        Conta GetByIdLogin(int idLogin);
    }
}
