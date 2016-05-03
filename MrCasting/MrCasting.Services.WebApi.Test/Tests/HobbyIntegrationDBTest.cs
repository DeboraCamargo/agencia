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
    public class HobbyIntegrationDBTest
    {

        private static TestServer _server;

        public HobbyIntegrationDBTest()
        {
            _server = TestServer.Create<StartupDB>();
        }

        [TestMethod]
        public void HobbyController_Get_PassandoId_RetornaHobby()
        {
            int id = 1;
            var response = _server.HttpClient.GetAsync("api/Hobby/1").Result;
            var hobbyJson = response.Content.ReadAsStringAsync().Result;
            HobbyDTO hobbydto = JsonConvert.DeserializeObject<HobbyDTO>(hobbyJson);

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreEqual(id, hobbydto.Id);
        }

        [TestMethod]
        public void HobbyController_Insert_PassandoHobbyDTO_RetornaStatusSucesso()
        {
            HobbyDTO hobbydto = new HobbyDTO()
            {
                IdCandidato = 1,
                NomeHobby = "Ciclismo"
            };

            string jsonString = JsonConvert.SerializeObject(hobbydto);
            var response = _server.HttpClient.PostAsJsonAsync("api/Hobby", hobbydto).Result;
            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void HobbyController_Update_RetornaStatusSucesso()
        {
            int idCandidato = 1; // Colocar um id candidato ã inserido na base de dados
            List<HobbyDTO> ListaHobbyDTO = new List<HobbyDTO>();

            HobbyDTO hobbyDTO = HobbySamples.CriarHobbyDTO();
            hobbyDTO.NomeHobby = "Malabares";
            hobbyDTO.Id = 0;
            hobbyDTO.IdCandidato = 1;

            ListaHobbyDTO.Add(hobbyDTO);
            var response = _server.HttpClient.PutAsJsonAsync("api/Hobby/" + idCandidato, ListaHobbyDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

    }
}
