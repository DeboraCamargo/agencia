using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.DTO;
using MrCasting.Services.WebApi.Test.Setup;
using MrCasting.Testing.Helpers.EntitiesSamples;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Services.WebApi.Test.Tests
{
    [TestClass]
    public class HabilidadeIntegrationDBTest
    {
        private static TestServer _server;

        public HabilidadeIntegrationDBTest()
        {
            _server = TestServer.Create<StartupDB>();
        }

        [TestMethod]
        public void HabilidadeController_Get_PassandoId_RetornaHabilidade()
        {
            int id = 1;
            var response = _server.HttpClient.GetAsync("api/Habilidade/1").Result;
            var habilidadeJson = response.Content.ReadAsStringAsync().Result;
            HabilidadeDTO habilidadedto = JsonConvert.DeserializeObject<HabilidadeDTO>(habilidadeJson);

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreEqual(id, habilidadedto.Id);
        }

        [TestMethod]
        public void HabilidadeController_Update_PassandoHabilidadeDTO_RetornaStatusSucesso()
        {
            int idCandidato = 1; // Colocar um id candidato ã inserido na base de dados
            List<HabilidadeDTO> ListaHabilidadeDTO = new List<HabilidadeDTO>();

            HabilidadeDTO habilidadeDTO = HabilidadeSamples.CriarHabilidadeDTO();
            habilidadeDTO.NomeHabilidade = "Dançaforroforoo";

            ListaHabilidadeDTO.Add(habilidadeDTO);
            var response = _server.HttpClient.PutAsJsonAsync("api/Habilidade/" + idCandidato, ListaHabilidadeDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

    }
}
