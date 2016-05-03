using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.DTO;
using MrCasting.Services.WebApi.Test.Setup;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace MrCasting.Services.WebApi.Test.Tests
{
    [TestClass]
    public class LoginOAuthIntegrationTest
    {
        private static TestServer _server;

        public LoginOAuthIntegrationTest()
        {
            _server = TestServer.Create<StartupDB>();
        }

        [TestMethod]
        public void LoginOAuthController_Logar_Falha()
        {
            string email = "teste@teste.com";
            LoginOAuthDTO dto = new LoginOAuthDTO();
            dto.Email = email;
            dto.Token = "CAAVdp8j0kssBAEHToyBPWRBZBuKgF89OAdrmiufjXZBH8KrC7pM7jg6RlK8x9jNrET6P1JQm6xbGZAlF3TCyCP4b6zrNEQnmeOFDiqerF9Oo5f016qugneiQonFCHBOyZAYjXeBM68A0TSvfJSFrlqNSd1DS48SczpX0BqjyHiWesZAbLGC7RH5jMhD3zh2wgZBQ6FSsiDwgZDZD";
            
            var response = _server.HttpClient.PostAsJsonAsync("api/LoginOAuth/Login", dto).Result;
            Assert.AreEqual(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [TestMethod]
        public void LoginOAuthController_Logar_Sucesso()
        {
            string email = "me.imagine.debby@gmail.com";
            string nome = "Debora";
            LoginOAuthDTO dto = new LoginOAuthDTO();
            dto.Email = email;
            dto.Token = "TOKENTOKEN";

            var response = _server.HttpClient.PostAsJsonAsync("api/LoginOAuth/Login", dto).Result;
            var contaJson = response.Content.ReadAsStringAsync().Result;
            CandidatoDTO candidato = JsonConvert.DeserializeObject<CandidatoDTO>(contaJson);
            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreEqual(nome, candidato.DadosPessoais.Nome);
        }

    }
}
