using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Repositories;
using MrCasting.Services.WebApi.Test.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Services.WebApi.Test.Tests
{
    [TestClass]
   public class VagaIntegrationDBTest
    {
        private static TestServer _server;
        private static IVagaRepository vagaRepository = new VagaRepository(new Infra.Data.Contexts.GeneralContext());

        public VagaIntegrationDBTest()
        {
            _server = TestServer.Create<StartupDB>();
        }

        [ClassCleanup()]
        public static void TearDown()
        {
            _server.Dispose();
        }

        //void CadastrarVaga(Vaga vaga);
        //IEnumerable<string> ConsultarVagas(int idVaga);
        //IEnumerable<string> ConsultarTodasVagasPorScouter(int idScouter);
        //void RemoverVaga(int idVaga);
        //void EditarVaga(Vaga vaga);


    }
}
