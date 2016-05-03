using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.DTO;
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
   public class VideoIntegrationDBTest
    {
        private static TestServer _server;
        private static IVideoRepository videoRepository = new VideoRepository(new Infra.Data.Contexts.GeneralContext());

        public VideoIntegrationDBTest()
        {
            _server = TestServer.Create<StartupDB>();
        }

        [ClassCleanup()]
        public static void TearDown()
        {
            _server.Dispose();
        }

        //void CadastrarVideo(VideoObj video);
        //IEnumerable<string> ConsultarVideos(int idcandidato);
        //void RemoverVideo(int idVideo);
        [TestMethod]
        public void HobbyController_Insert_RetornaStatusSucesso()
        {
            int idCandidato = 1; // Colocar um id candidato ã inserido na base de dados

            VideoDTO videoDTO = VideoSamples.CriarVideoDTO();
            videoDTO.Video = "http://lololololo.com";
            videoDTO.IdCandidato = idCandidato;

            var response = _server.HttpClient.PostAsJsonAsync("api/Video", videoDTO).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
        }

    }
}
