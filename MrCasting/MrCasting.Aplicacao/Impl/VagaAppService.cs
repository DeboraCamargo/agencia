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
    public class VagaAppService : AppServiceBase<Vaga>, IVagaAppService
    {
        private readonly IVagaService _service;
        IVagaService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("VagaService não pode ser nulo");
                return _service;
            }
        }

        public VagaAppService(IVagaService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarVaga(Vaga vaga)
        {
            Service.CadastrarVaga(vaga);
        }

        public IEnumerable<string> ConsultarVagas(int idVaga)
        {
            return Service.ConsultarVagas(idVaga);
        }

        public IEnumerable<string> ConsultarTodasVagasPorScouter(int idScouter)
        {
            return Service.ConsultarTodasVagasPorScouter(idScouter);
        }

        public void RemoverVaga(int idVaga)
        {
            Service.RemoverVaga(idVaga);
        }

        public void EditarVaga(int idVaga, Vaga vaga)
        {
            Service.EditarVaga(idVaga, vaga);
        }
    }
}
