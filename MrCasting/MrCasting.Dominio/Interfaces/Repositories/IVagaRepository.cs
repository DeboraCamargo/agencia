using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface IVagaRepository : IRepository<Vaga>
    {
        void CadastrarVaga(Vaga vaga);
        IEnumerable<string> ConsultarVagas(int idVaga);
        IEnumerable<string> ConsultarTodasVagasPorScouter(int idScouter);
        void RemoverVaga(int idVaga);
        void EditarVaga(int idvaga, Vaga vaga);
    }
}
