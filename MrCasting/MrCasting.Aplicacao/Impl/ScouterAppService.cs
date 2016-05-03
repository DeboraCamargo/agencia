using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrCasting.Domain.DTO;

namespace MrCasting.Application.Impl
{
    public class ScouterAppService : AppServiceBase<Scouter>, IScouterAppService
    {

        private readonly IScouterService _service;
        IScouterService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("ScouterService não pode ser nulo");
                return _service;
            }
        }

        public ScouterAppService(IScouterService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarScouter(Scouter scouter)
        {
            Service.CadastrarScouter(scouter);
        }

        public IEnumerable<Scouter> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais)
        {
            return Service.PesquisarPorDadosPessoais(pesquisaDadosPessoais);
        }

        public void EditarScouter(int idScouter, Scouter scouter)
        {
            Service.EditarScouter(idScouter, scouter);
        }
    }
    
}
