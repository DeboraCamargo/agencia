using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Services
{
    public interface IFotoService : IServiceBase<FotoObj>
    {
        void CadastrarFoto(FotoObj foto);
        IEnumerable<FotoObj> ConsultarFotos(int idcandidato);
        void RemoverFoto(int idFoto);
    }
}
