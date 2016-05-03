using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.DTO;
using MrCasting.Services.WebApi.Test.Setup;
using MrCasting.Testing.Helpers.EntitiesSamples;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MrCasting.Services.WebApi.Test.Tests
{
    [TestClass]
    public class CaracteristicaFisicaIntegrationDBTest
    {
        private static TestServer _server;

        public CaracteristicaFisicaIntegrationDBTest()
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

        [ClassCleanup()]
        public static void TearDown()
        {
            _server.Dispose();
        }

        [TestMethod]
        public void CaracteristicaFisicaController_Get_PassandoId_RetornaCaracteristica()
        {
            int id = 1;
            var response = _server.HttpClient.GetAsync("api/CaracteristicasFisicas/1").Result;
            var caracterisitcaJson = response.Content.ReadAsStringAsync().Result;
            CaracteristicasFisicasDTO caracteristicasFisicasDTO = JsonConvert.DeserializeObject<CaracteristicasFisicasDTO>(caracterisitcaJson);

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreEqual(id, caracteristicasFisicasDTO.IdCandidato);
        }

        [TestMethod]
        public void CaracteristicaFisicaController_Insert_PassandoCaracteristicaDTO_RetornaStatusSucesso()
        {
            //// preciso de um candidato que esteja na base
            //CaracteristicasFisicasDTO carcFisicaDTO = new CaracteristicasFisicasDTO()
            //{
            //    IdCandidato = 1,
            //    Altura = 1.6m,
            //    Busto = 0.70m,
            //    Camisa = "Listrada", // Ver se obrigatorio
            //    Cintura = 0.60m,
            //    ComprimentoCabelo = "Longo",
            //    CorDaPele = "Preta",
            //    CorDosOlhos = "Azul",
            //    Descendencia = "Afro",
            //    Etnia = "Turca",
            //    Manequim = 40,
            //    Peso = 100,
            //    Quadril = 1,
            //    Sapato = 42,
            //    TipoCabelo = "afro",
            //    TipoFisico = "Obesa"
            //};

            //string jsonString = JsonConvert.SerializeObject(carcFisicaDTO);
            ////var response = _server.HttpClient.PostAsync("api/CaracteristicasFisicas", new StringContent(jsonString, Encoding.UTF8, "application/json")).Result;

            //var response = _server.HttpClient.PostAsJsonAsync("api/CaracteristicasFisicas", carcFisicaDTO).Result;

            //Assert.IsTrue(response.IsSuccessStatusCode);
        }

        [TestMethod]
        public void CaracteristicaFisicaController_Update_RetornaStatusSucesso()
        {
            int idCandidato = 1; // Colocar um id candidato ã inserido na base de dados
            CaracteristicasFisicasDTO caracteristicaFisicaDTO = CaracteristicasFisicasSamples.CriarCaracteristicaFisicaDTO();

            caracteristicaFisicaDTO.Altura = 1.55m;
            caracteristicaFisicaDTO.Busto = 0.50m;
            caracteristicaFisicaDTO.Camisa = "Grande";
            caracteristicaFisicaDTO.Cintura = 0.60m;
            caracteristicaFisicaDTO.ComprimentoCabelo = "Longo";
            caracteristicaFisicaDTO.CorOlhos = "Castanho escuro";
            caracteristicaFisicaDTO.CorPele = "Preta";
            //Deve SIM poder Conter caracter especial ex POrto-riquenho?????
            caracteristicaFisicaDTO.Descendencia = "AfroBrasileira";
            caracteristicaFisicaDTO.Etnia = "negra";
            caracteristicaFisicaDTO.Manequim = 42m;
            caracteristicaFisicaDTO.Peso = 72m;
            caracteristicaFisicaDTO.Quadril = 0.50m;
            caracteristicaFisicaDTO.Sapato = 35m;
            caracteristicaFisicaDTO.Terno = "Grande";
            caracteristicaFisicaDTO.TipoCabelo = "Crespo";
            caracteristicaFisicaDTO.TipoFisico = "Acima do Peso";
            caracteristicaFisicaDTO.Torax = 0.40m;


            var response = _server.HttpClient.PutAsJsonAsync("api/CaracteristicasFisicas/" + idCandidato, caracteristicaFisicaDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

    }
}
