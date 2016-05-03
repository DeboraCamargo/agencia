using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Interfaces.Services
{
   public interface IHobbyService : IServiceBase<Hobby>
    {

        void EditarHobby(int idCandidato, List<Hobby> hobby);
        void CadastrarHobby(Hobby hobby);

    }
}
