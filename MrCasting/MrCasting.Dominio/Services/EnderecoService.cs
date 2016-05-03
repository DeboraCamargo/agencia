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
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _repository;
        IEnderecoRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("EnderecoRepository não pode ser nulo");
                return _repository;
            }
        }

        public EnderecoService(IEnderecoRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void CadastrarEndereco(Endereco endereco)
        {
            Repository.CadastrarEndereco(endereco);
        }

        public void EditarEndereco(int IdCandidato, Endereco enderoco)
        {
            Repository.EditarEndereco(IdCandidato, enderoco);

        }
    }
}