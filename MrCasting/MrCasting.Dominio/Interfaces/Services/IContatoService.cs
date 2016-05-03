using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Services
{
    public interface IContatoService : IServiceBase<Contato>
    {
        void CadastrarContato(Contato contato);
        void Editar(int idPessoa, Contato contato);
    }
}
