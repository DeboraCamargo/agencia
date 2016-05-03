using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface IFotoRepository : IRepository<FotoObj>
    {
        void CadastrarFoto(FotoObj foto);
        IEnumerable<FotoObj> ConsultarFotos(int idCandidato);
        void RemoverFoto(int idFoto);
    }
}
