using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Application.Impl
{
   public class HabilidadeAppService : AppServiceBase<Habilidade>, IHabilidadeAppService
    {

        private readonly IHabilidadeService _service;
        IHabilidadeService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("HabilidadeService não pode ser nulo");
                return _service;
            }
        }
        public HabilidadeAppService(IHabilidadeService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarHabilidade(Habilidade habilidade)
        {
            Service.CadastrarHabilidade(habilidade);
        }

        public void EditarHabilidade(int idCandidato, List<Habilidade> habilidades)
        {
            Service.EditarHabilidade(idCandidato, habilidades);
        }
    }
}
