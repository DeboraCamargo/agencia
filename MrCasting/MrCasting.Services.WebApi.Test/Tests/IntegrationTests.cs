using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Owin.Testing;
using MrCasting.Services.WebApi.Test.Setup;
using System.Net.Http;
using Newtonsoft.Json;
using MrCasting.Domain.DTO;
using MrCasting.Testing.Helpers.EntitiesSamples;
using System.Text;

namespace MrCasting.Services.WebApi.Test.Tests
{
    /// <summary>
    /// Summary description for IntegrationTests
    /// </summary>
    [TestClass]
    public class IntegrationTests
    {
        private static TestServer _server;

        public IntegrationTests()
        {
            _server = TestServer.Create<StartupMock>();
        }

        [ClassCleanup()]
        public static void TearDown()
        {
            _server.Dispose();
        }

        [TestMethod]
        public void Test1()
        {
            var response = _server.HttpClient.GetAsync("api/test/1").Result;
            var candidatoJson = response.Content.ReadAsStringAsync().Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }


        [TestMethod]
        public void CandidatoController_Get_PassandoId_RetornaCandidato()
        {
            int id = 1;
            var response = _server.HttpClient.GetAsync("api/candidato/1").Result;
            var candidatoJson = response.Content.ReadAsStringAsync().Result;
            CandidatoDTO candidato = JsonConvert.DeserializeObject<CandidatoDTO>(candidatoJson);

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreEqual(id, candidato.Id);
        }

        [TestMethod]
        public void CandidatoController_Insert_PassandoCandidatoDTO_RetornaStatusSucesso()
        {
            CandidatoDTO candidatoDTO = CandidatoSamples.CreateCandidatoDTO(4);
            var response = _server.HttpClient.PostAsJsonAsync("api/Candidato", candidatoDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void CandidatiController_Update_PassandoCandidatoDTO_RetornaSucesso()
        {
            CandidatoDTO candidatoDTO = CandidatoSamples.CreateCandidatoDTO(4);
            var response = _server.HttpClient.PutAsJsonAsync("api/Candidato", candidatoDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void CandidatiController_Delete_PassandoCandidatoDTO_RetornaSucesso()
        {
            int id = 1;
            var response = _server.HttpClient.DeleteAsync(string.Format("api/Candidato/{0}", id)).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void CaracteristicaFisicaController_Insert_PassandoCaracteristicaDTO_RetornaStatusSucesso()
        {
            // preciso de um candidato que esteja na base
            CaracteristicasFisicasDTO carcFisicaDTO = new CaracteristicasFisicasDTO()
            {
                IdCandidato = 1,
                Altura = 1.6m,
                Busto = 0.70m,
                Camisa = "40", // Ver se obrigatorio
                Cintura = 0.60m,
                ComprimentoCabelo = "Longo",
                CorPele = "Preta",
                CorOlhos = "Azul",
                Descendencia = "Afro",
                Etnia = "Turca",
                Manequim = 40,
                Peso = 100,
                Quadril = 1,
                Sapato = 42,
                TipoCabelo = "afro",
                TipoFisico = "Obesa"
            };

            string jsonString = JsonConvert.SerializeObject(carcFisicaDTO);
            var response = _server.HttpClient.PostAsync("api/CaracteristicasFisicas", new StringContent(jsonString, Encoding.UTF8, "application/json")).Result;

            //var response = _server.HttpClient.PostAsJsonAsync("api/CaracteristicasFisicas", carcFisicaDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }
    }
}
