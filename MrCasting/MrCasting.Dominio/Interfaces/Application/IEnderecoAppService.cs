using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Application
{
   public interface IEnderecoAppService : IAppServiceBase<Endereco>
    {
        void CadastrarEndereco(Endereco endereco);
        void EditarEndereco(int IdPessoa, Endereco enderoco);
    }
}
