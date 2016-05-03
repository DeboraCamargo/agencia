using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        void AtualizarPessoa(Pessoa pessoa);
        void CadastrarPessoa(Pessoa pessoa);
        List<Pessoa> ListarPessoaPorNome(string nome);
        List<Pessoa> ListarPessoaPorSobrenome(string sobrenome);
        List<Pessoa> ListarPessoaPorDataNascimento(DateTime data);
        List<Pessoa> ListarPessoaPorSexo(Genero sexo);

    }
}
