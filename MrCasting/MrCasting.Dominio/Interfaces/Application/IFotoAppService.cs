using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Application
{
    public interface IFotoAppService : IAppServiceBase<FotoObj>
    {
        void CadastrarFoto(FotoObj fotoObj);
        IEnumerable<FotoObj> ConsultarFotos(int idCandidato);
        void RemoverFoto(int idFoto);

    }
}
