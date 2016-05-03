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
    public class InteresseService : ServiceBase<Interesse>, IInteresseService
    {

        public InteresseService(IInteresseRepository repository) : base(repository)
        {
            this._repository = repository;
        }


        public void CadastrarInteresse(Interesse interesse)
        {
            Repository.CadastrarInteresse(interesse);
        }

        public IEnumerable<Interesse> PesquisarPorInteresse(Interesse interesse)
        {
            throw new NotImplementedException();
        }

        public void EditarInteresse(int IdCandidato, Interesse interesse)
        {
            Repository.EditarInteresse(IdCandidato, interesse);
        }

        private readonly IInteresseRepository _repository;
        IInteresseRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("InteresseAppService não pode ser nulo");
                return _repository;
            }
        }

       
    }
  
}
