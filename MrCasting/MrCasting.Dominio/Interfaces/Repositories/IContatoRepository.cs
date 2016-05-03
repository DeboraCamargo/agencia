using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface IContatoRepository : IRepository<Contato>
    {
        void CadastrarContato(Contato contato);
        void Editar(int idPessoa, Contato contato);
    }
}
