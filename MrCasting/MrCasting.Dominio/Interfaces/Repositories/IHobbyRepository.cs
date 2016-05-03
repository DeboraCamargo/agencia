using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using System.Collections.Generic;

namespace MrCasting.Domain.Interfaces.Repositories
{
    public interface IHobbyRepository : IRepository<Hobby>
    {
        void CadastrarHobby(Hobby hobby);
        void EditarHobby(int idCandidato, List<Hobby> hobby);

    }
}
