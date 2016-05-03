using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Services
{
    public class HobbyService : ServiceBase<Hobby>, IHobbyService
    {
        private readonly IHobbyRepository _repository;
        IHobbyRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("Hobby AppService não pode ser nulo");
                return _repository;
            }
        }

        public HobbyService(IHobbyRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void EditarHobby(int idCandidato, List<Hobby> hobby)
        {
            Repository.EditarHobby(idCandidato, hobby);
        }

        public void CadastrarHobby(Hobby hobby)
        {
            throw new NotImplementedException();
        }
    }
}
