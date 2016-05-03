using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Application
{
    public interface IPessoaAppService : IAppServiceBase<Pessoa>
    {
        void AtualizarPessoa(Pessoa pessoa);
        void CadastrarPessoa(Pessoa pessoa);
    }
}
