using MrCasting.Domain.DTO;
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
    public class FotoService : ServiceBase<FotoObj>, IFotoService
    {

        private readonly IFotoRepository _repository;
        IFotoRepository Repository
        {
            get
            {
                if (_repository == null)
                    throw new Exception("FotoRepository não pode ser nulo");
                return _repository;
            }
        }

        public FotoService(IFotoRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public IEnumerable<FotoObj> ConsultarFotos(int idCandidato)
        {
            return Repository.ConsultarFotos(idCandidato);
        }

        public void RemoverFoto(int idFoto)
        {
            Repository.RemoverFoto(idFoto);
        }

        public void CadastrarFoto(FotoObj foto)
        {
            Repository.CadastrarFoto(foto);
        }
    }
}
