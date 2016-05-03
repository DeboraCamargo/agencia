using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MrCasting.Services.Controllers
{
    public class PessoaController : ApiController
    {

        private readonly IPessoaAppService service;
        IPessoaAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("PessoaAppService não pode ser nulo");
                return service;
            }
        }

        public PessoaController() { }

        public PessoaController(IPessoaAppService service)
        {
            this.service = service;
        }

        // GET: api/Pessoa
        public IEnumerable<PessoaDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToPessoaDTO());
        }

        // GET: api/Pessoa/5
        public PessoaDTO Get(int id)
        {
            Pessoa pessoa = Service.GetById(id);
            if (pessoa == null)
                return null;
            else
                return pessoa.ToPessoaDTO();
        }

        // POST: api/Pessoa
        public void Post(PessoaDTO pessoaDTO)
        {
            Service.CadastrarPessoa(pessoaDTO.ToPessoa());
        }

        // PUT: api/Pessoa/5
        public void Put(int id, PessoaDTO pessoaDTO)
        {
            Service.AtualizarPessoa(pessoaDTO.ToPessoa());
        }

        // DELETE: api/CaracteristicasFisicas/5
        public void Delete(int id)
        {
        }

    }
}
 