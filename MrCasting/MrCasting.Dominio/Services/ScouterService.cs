using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrCasting.Domain.DTO;

namespace MrCasting.Domain.Services
{
    public class ScouterService : ServiceBase<Scouter>, IScouterService
    {

        private readonly IScouterRepository _repository;
        IScouterRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("ScouterRepository não pode ser nulo");
                return _repository;
            }
        }

        public ScouterService(IScouterRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void CadastrarScouter(Scouter scouter)
        {
            Repository.CadastrarScouter(scouter);
        }

        public IEnumerable<Scouter> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais)
        {
            return Repository.PesquisarPorDadosPessoais(pesquisaDadosPessoais);
        }

        public void EditarScouter(int idScouter, Scouter scouter)
        {
            Repository.EditarScouter(idScouter, scouter);
        }
    }
}
