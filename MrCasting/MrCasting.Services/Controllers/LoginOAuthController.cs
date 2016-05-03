using MrCasting.Domain.DTO;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using MrCasting.Domain.Exceptions;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Application;
using System;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace MrCasting.Services.Controllers
{
    public class LoginOAuthController : ApiController
    {
        private readonly ILoginOAuthAppService service;
        ILoginOAuthAppService Service
        {
            get
            {
                if (service == null)
                    throw new Exception("CandidatoAppService não pode ser nulo");
                return service;
            }
        }

        public LoginOAuthController() { }

        public LoginOAuthController(ILoginOAuthAppService service)
        {
            this.service = service;
        }

        [Route("api/LoginOAuth/Login")]
        [HttpPost]
        public CandidatoDTO RealizarLogin(LoginOAuthDTO loginDTO)
        {
            LoginOAuth login = loginDTO.ToLoginOAuth();
            
            try
            {
                Conta conta = Service.Logar(login);
                if (conta.Tipo == TipoConta.Scouter)
                    throw new HttpResponseException(HttpStatusCode.Moved);
                Candidato candidato = conta.Candidato;
                return candidato.ToCandidatoDTO();
            }
            catch (UsuarioNaoCadastradoException)
            {
                throw new HttpResponseException(HttpStatusCode.Unauthorized);
            }
            
        }

    }
}
