using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.DTO;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Repositories;
using MrCasting.Services.WebApi.Test.Setup;
using MrCasting.Testing.Helpers.EntitiesSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Services.WebApi.Test.Tests
{
    [TestClass]
   public class EnderecoIntegrationDBtest
    {
        private static TestServer _server;
        private static IEnderecoRepository enderecoRepository = new EnderecoRepository(new Infra.Data.Contexts.GeneralContext());

        public EnderecoIntegrationDBtest()
        {
            _server = TestServer.Create<StartupDB>();
        }

        [ClassCleanup()]
        public static void TearDown()
        {
            _server.Dispose();
        }


        [TestMethod]
        public void EnderecoController_Insert_PassandoEnderecoDTO_RetornaStatusSucesso()
        {
            EnderecoDTO enderecoDTO = EnderecoSamples.CriarEnderecoDTO();
            var response = _server.HttpClient.PostAsJsonAsync("api/Endereco", enderecoDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void EnderecoController_Update_EnderecoSamplespdate_PassandoEnderecoDTO_RetornaStatusSucesso()
        { 
            int idCandidato = 1; // Colocar um id candidato ã inserido na base de dados
            EnderecoDTO enderecoDTO = EnderecoSamples.CriarEnderecoDTO();
            enderecoDTO.Bairro = "Guaianazes";
            enderecoDTO.Cep = "03014000";
            enderecoDTO.Cidade = "Sao Paulo";
            enderecoDTO.Complemento = "Ap134bl18";
            enderecoDTO.Logradouro = "Avenida Celso Garcia 2";
            enderecoDTO.Numero = "23";
            enderecoDTO.Uf = Domain.Enuns.Uf.AC;

            var response = _server.HttpClient.PutAsJsonAsync("api/Endereco/" + idCandidato, enderecoDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void EnderecoController_Update_EnderecoSamplespdate_PassandoIdDeCandidatoQueNaoExiste_RetornaStatusFalha()
        {
            int idCandidato = 9999; // Colocar um id candidato ã inserido na base de dados
            EnderecoDTO enderecoDTO = EnderecoSamples.CriarEnderecoDTO();
            enderecoDTO.Bairro = "Guaianazeseseses";
            enderecoDTO.Cep = "03014000";
            enderecoDTO.Cidade = "Sao Paulo";
            enderecoDTO.Complemento = "Ap134bl18";
            enderecoDTO.Logradouro = "Avenida Celso Garcia 2";
            enderecoDTO.Numero = "23";
            enderecoDTO.Uf = Domain.Enuns.Uf.AC;

            var response = _server.HttpClient.PutAsJsonAsync("api/Endereco/" + idCandidato, enderecoDTO).Result;

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.BadRequest);
        }

    }
}
