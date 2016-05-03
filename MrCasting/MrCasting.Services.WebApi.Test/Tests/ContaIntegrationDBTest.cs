using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.DTO;
using MrCasting.Services.WebApi.Test.Setup;
using MrCasting.Testing.Helpers.EntitiesSamples;
using System.Net.Http;

namespace MrCasting.Services.WebApi.Test.Tests
{
    [TestClass]
    public class ContaIntegrationDBTest
    {
        private static TestServer _server;

        public ContaIntegrationDBTest()
        {
            _server = TestServer.Create<StartupDB>();
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        

        [TestMethod]
        public void ContaController_Insert_PassandoContaDTO_RetornaStatusSucesso()
        {
            ContaDTO contaDTO = ContaSamples.CreateContaDTO(0);
            contaDTO.Candidato.Id = 0;
            contaDTO.Candidato.DadosPessoais.Id = 0;
            contaDTO.Candidato.Interesse.Id = 0;
            contaDTO.Candidato.DadosPessoais.Contato.IdPessoa = 0;

            var response = _server.HttpClient.PostAsJsonAsync("api/Conta", contaDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

    }
}
