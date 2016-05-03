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
   public class ScouterController : ApiController
    {

        private readonly IScouterAppService service;
        IScouterAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("ScouterAppService não pode ser nulo");
                return service;
            }
        }

        public ScouterController()
        {
        }

        public ScouterController(IScouterAppService service)
        {
            this.service = service;
        }

        // GET: api/Scouter
        public IEnumerable<ScouterDTO> Get()
        {
            return Service.GetAll().Select(c => c.ToScouterDTO());
        }

        public ScouterDTO Get(int id)
        {
            Scouter scouter = Service.GetById(id);
            if (scouter == null)
                return null;
            else
                return scouter.ToScouterDTO();
        }

        // POST: api/Candidato
        public void Post(ScouterDTO scouterDTO)
        {
            Service.CadastrarScouter(scouterDTO.ToScouter());
        }

        // PUT: api/Candidato/5
        public void Put(int id, [FromBody]ScouterDTO  scouterDTO)
        {
            Service.EditarScouter(id, scouterDTO.ToScouter());
        }

        // DELETE: api/Candidato/5
        public void Delete(int id)
        {
        }

        [Route("api/PesquisaScouter/DadosInfo")]
        [HttpPost]
        public IEnumerable<ScouterDTO> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais)
        {
            IEnumerable<Scouter> scouter = Service.PesquisarPorDadosPessoais(pesquisaDadosPessoais);
            return scouter.Select(c => c.ToScouterDTO());
        }
    }
}