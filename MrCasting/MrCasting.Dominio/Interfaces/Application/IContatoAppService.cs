using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Application
{
   public interface IContatoAppService : IAppServiceBase<Contato>
    {
        void CadastrarContato(Contato contato);
        void Editar(int idPessoa, Contato contato);
    }
}
