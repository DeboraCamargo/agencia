using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Application
{
   public interface IHobbyAppService: IAppServiceBase<Hobby>
    {
        void CadastrarHobby(Hobby hobby);
        void EditarHobby(int idCandidato, List<Hobby> hobby);
    }
}
