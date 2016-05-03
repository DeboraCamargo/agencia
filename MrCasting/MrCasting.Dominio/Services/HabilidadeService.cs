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
    public class HabilidadeService : ServiceBase<Habilidade>, IHabilidadeService
    {
        private readonly IHabilidadeRepository _repository;
        IHabilidadeRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("Habilidade AppService não pode ser nulo");
                return _repository;
            }
        }

        public HabilidadeService(IHabilidadeRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void EditarHabilidade(int idCandidato, List<Habilidade> habilidades)
        {
            Repository.EditarHabilidade(idCandidato, habilidades);
        }

        public void CadastrarHabilidade(Habilidade habilidade)
        {
            Repository.CadastrarHabilidade(habilidade);
        }
    }
}
