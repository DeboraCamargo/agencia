using System;
using System.Collections.Generic;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using MrCasting.Domain.Interfaces.Services;
using MrCasting.Domain.Interfaces.Repositories;

namespace MrCasting.Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {

        private readonly IPessoaRepository _repository;
        IPessoaRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("Pessoa AppService não pode ser nulo");
                return _repository;
            }
        }

        public PessoaService(IPessoaRepository repository) : base(repository)
        {
            this._repository = repository;
        }


        public List<Pessoa> ListarPessoaPorDataNascimento(DateTime data)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ListarPessoaPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ListarPessoaPorSexo(Genero sexo)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ListarPessoaPorSobrenome(string sobrenome)
        {
            throw new NotImplementedException();
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            _repository.CadastrarPessoa(pessoa);
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            _repository.AtualizarPessoa(pessoa);
        }
    }
}
