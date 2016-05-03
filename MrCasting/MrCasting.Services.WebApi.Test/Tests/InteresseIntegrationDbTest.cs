using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.DTO;
using MrCasting.Services.WebApi.Test.Setup;
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
    public class InteresseIntegrationDbTest
    {
        private static TestServer _server;

        public InteresseIntegrationDbTest()
        {
            _server = TestServer.Create<StartupDB>();
        }

        [TestMethod]
        public void InteresseController_Get_PassandoId_RetornaInteresse()
        {
            int id = 1;
            var response = _server.HttpClient.GetAsync("api/Interesse/1").Result;
            var interesseJson = response.Content.ReadAsStringAsync().Result;
            InteresseDTO interessedto = JsonConvert.DeserializeObject<InteresseDTO>(interesseJson);

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreEqual(id, interessedto.Id);
        }

        [TestMethod]
        public void InteresseController_Insert_PassandoInteresseDTO_RetornaStatusSucesso()
        {
            InteresseDTO interessedto = new InteresseDTO()
            {
                Ator = true,
                Evento = false,
                Figurante = true,
                Modelo = true,
                ModeloPlusSize = false

            };

            string jsonString = JsonConvert.SerializeObject(interessedto);
            var response = _server.HttpClient.PostAsJsonAsync("api/Interesse", interessedto).Result;
            Assert.IsTrue(response.IsSuccessStatusCode);
        }

    }
}
