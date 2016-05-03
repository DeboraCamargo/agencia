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
   public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _service;
        IEnderecoService Service
        {
            get
            {
                if (_service == null)
                    throw new Exception("EnderecoService não pode ser nulo");
                return _service;
            }
        }

        public EnderecoAppService(IEnderecoService service) : base(service)
        {
            _service = service;
        }

        public void CadastrarEndereco(Endereco endereco)
        {
            Service.CadastrarEndereco(endereco);
        }

        public void EditarEndereco(int IdCandidato, Endereco enderoco)
        {
            Service.EditarEndereco(IdCandidato, enderoco);
        }
    }
}
