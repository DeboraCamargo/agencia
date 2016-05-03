using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Domain.Interfaces.Services;
using System;

namespace MrCasting.Domain.Services
{
    public class ContatoService : ServiceBase<Contato>, IContatoService
    {
        private readonly IContatoRepository _repository;
        IContatoRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("ContatoRepository não pode ser nulo");
                return _repository;
            }
        }

        public ContatoService(IContatoRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public void CadastrarContato(Contato contato)
        {
            _repository.CadastrarContato(contato);
        }

        public void Editar(int id, Contato contato)
        {
            Repository.Editar(id, contato);
        }
    }
}
