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
   public class PessoaIntegrationDbTest
    {
        private static TestServer _server;

        public PessoaIntegrationDbTest()
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
        public void PessoaController_Get_PassandoId_RetornaPessoa()
        {
            int id = 1;
            var response = _server.HttpClient.GetAsync("api/Pessoa/1").Result;
            var PessoaJson = response.Content.ReadAsStringAsync().Result;
            PessoaDTO pessoaDTO = JsonConvert.DeserializeObject<PessoaDTO>(PessoaJson);

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreEqual(id, pessoaDTO.IdCandidato);
        }

        [TestMethod]
        public void PessoaController_Insert_PassandoPessoaDTO_RetornaStatusSucesso()
        {
            PessoaDTO pessoadto = new PessoaDTO()
            {
                Contato = new ContatoDTO(),
                Cpf = "33550028873",
                DataNascimento = new DateTime(07, 01, 1989),
                Endereco = new EnderecoDTO(),
                IdCandidato=1,
                Nome="Debora",
                Sexo = Domain.Enuns.Genero.Feminino,
                Sobrenome = "Barbosa"
            };

            string jsonString = JsonConvert.SerializeObject(pessoadto);
            var response = _server.HttpClient.PostAsJsonAsync("api/Pessoa", pessoadto).Result;
            Assert.IsTrue(response.IsSuccessStatusCode);
        }

    }
}

