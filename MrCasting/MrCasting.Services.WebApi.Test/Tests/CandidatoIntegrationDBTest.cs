using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Owin.Testing;
using MrCasting.Services.WebApi.Test.Setup;
using MrCasting.Domain.DTO;
using Newtonsoft.Json;
using MrCasting.Testing.Helpers.EntitiesSamples;
using System.Net.Http;
using MrCasting.Domain.Enuns;
using System.Linq;

namespace MrCasting.Services.WebApi.Test.Tests
{
    /// <summary>
    /// Summary description for CandidatoIntegrationDBTest
    /// </summary>
    [TestClass]
    public class CandidatoIntegrationDBTest
    {
        private static TestServer _server;

        public CandidatoIntegrationDBTest()
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
        public void CandidatoController_Get_PassandoId_RetornaCandidato()
        {
            int id = 1;
            var response = _server.HttpClient.GetAsync("api/Candidato/1").Result;
            var candidatoJson = response.Content.ReadAsStringAsync().Result;
            CandidatoDTO candidato = JsonConvert.DeserializeObject<CandidatoDTO>(candidatoJson);

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreEqual(id, candidato.Id);
        }

        [TestMethod]
        public void CandidatoController_Insert_PassandoCandidatoDTO_RetornaStatusSucesso()
        {
            CandidatoDTO candidatoDTO = CandidatoSamples.CreateCandidatoDTO(0);
            var response = _server.HttpClient.PostAsJsonAsync("api/Candidato", candidatoDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void CandidatoController_Insert_PassandoJson_RetornaStatusSucesso()
        {
            string json = "{\"DadosPessoais\":{\"Nome\":\"alex\",\"SobreNome\":\"\",\"DataNascimento\":\"2015-11-18T05:00:00.000Z\",\"Sexo\":\"1\",\"Cpf\":\"31743357877\",\"Contato\":{\"Email\":\"lolo@toto.com\",\"Telefone\":\"11991400799\"}},\"NomeFantasia\":\"Alex Lotos\",\"Interesse\":{\"Ator\":true,\"Modelo\":false,\"ModeloPlusSize\":false,\"Evento\":false,\"Figurante\":false,\"Outros\":false,\"Mirin\":false}}";
            
            CandidatoDTO dto = JsonConvert.DeserializeObject<CandidatoDTO>(json);
            var response = _server.HttpClient.PostAsJsonAsync("api/Candidato", dto).Result;
            //var response = _server.HttpClient.PostAsync("api/Candidato", new StringContent(json,Encoding.UTF8, "application/json")).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void CandidatoController_Pesquisar_PassandoSexoFemininoParaPesquisaDTO_RetornarApenasCandidatosFeminino()
        {
            PesquisaDadosPessoaisDTO pesquisaDto = new PesquisaDadosPessoaisDTO()
            {
                Sexo = Genero.Feminino
            };
            var response = _server.HttpClient.PostAsJsonAsync("api/PesquisaCandidato/DadosInfo", pesquisaDto).Result;
            string candidatosJson = response.Content.ReadAsStringAsync().Result;
            IEnumerable<CandidatoDTO> candidatos = JsonConvert.DeserializeObject<IEnumerable<CandidatoDTO>>(candidatosJson);

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.IsTrue(candidatos.Any());
            Assert.AreEqual(Genero.Feminino, candidatos.First().DadosPessoais.Sexo);
        }
    }
}
