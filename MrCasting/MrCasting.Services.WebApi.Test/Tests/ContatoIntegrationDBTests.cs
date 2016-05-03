using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Domain.DTO;
using MrCasting.Infra.Data.Repositories;
using MrCasting.Services.WebApi.Test.Setup;
using MrCasting.Testing.Helpers.EntitiesSamples;
using System.Linq;
using System.Net.Http;

namespace MrCasting.Services.WebApi.Test.Tests
{
    [TestClass]
    public class ContatoIntegrationDBTests
    {
        private static TestServer _server;
            private static IContatoRepository contatoRepository = new ContatoRepository(new Infra.Data.Contexts.GeneralContext());

        public ContatoIntegrationDBTests()
        {
            _server = TestServer.Create<StartupDB>();
        }

        [ClassCleanup()]
        public static void TearDown()
        {
            _server.Dispose();
        }

        
        [TestMethod]
        public void ContatoController_Insert_PassandoContatoDTO_RetornaStatusSucesso()
        {
            ContatoDTO contatoDTO = ContatoSamples.CriarContatoDTOValido();
            var response = _server.HttpClient.PostAsJsonAsync("api/Contato", contatoDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void ContatoController_Update_ContatoSamplespdate_PassandoContatoDTO_RetornaStatusSucesso()
        {
            int idCandidato = 1; // Colocar um id candidato ã inserido na base de dados
            ContatoDTO contatoDTO = ContatoSamples.CriarContatoDTOValido();
            contatoDTO.Email = "Update_" + contatoDTO.Email;

            var response = _server.HttpClient.PutAsJsonAsync("api/Contato/"+idCandidato, contatoDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

    }
}
