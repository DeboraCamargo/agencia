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
    public class VagaService : ServiceBase<Vaga>, IVagaService
    {
        private readonly IVagaRepository _repository;
        IVagaRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("VagaRepository não pode ser nulo");
                return _repository;
            }
        }

        public VagaService(IVagaRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void CadastrarVaga(Vaga vaga)
        {
            _repository.CadastrarVaga(vaga);
        }

        public IEnumerable<string> ConsultarVagas(int idVaga)
        {
            return _repository.ConsultarVagas(idVaga);
        }

        public IEnumerable<string> ConsultarTodasVagasPorScouter(int idScouter)
        {
            return _repository.ConsultarTodasVagasPorScouter(idScouter);
        }

        public void RemoverVaga(int idVaga)
        {
            Repository.RemoverVaga(idVaga);
        }

        

        public void EditarVaga(int idvaga, Vaga vaga)
        {
            Repository.EditarVaga(idvaga, vaga);
        }
    }
}
