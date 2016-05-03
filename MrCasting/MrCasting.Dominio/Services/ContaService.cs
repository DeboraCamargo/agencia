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
 public class ContaService: ServiceBase<Conta>, IContaService
    {

        private readonly IContaRepository _repository;
        IContaRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("ContaRepository não pode ser nulo");
                return _repository;
            }
        }

        public ContaService(IContaRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public Conta GetByLogin(LoginOAuth _login)
        {
            return Repository.GetByLogin(_login);
        }

        public void CadastrarConta(Conta conta)
        {
            Repository.CadastrarConta(conta);
        }

        public Conta GetByIdLogin(int idLogin)
        {
            return Repository.GetByIdLogin(idLogin);
        }
    }
}
