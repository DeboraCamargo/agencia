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
   public class ScouterIntegrationDBTest
    {
        private static TestServer _server;
        private static IScouterRepository scouterRepository = new ScouterRepository(new Infra.Data.Contexts.GeneralContext());

        public ScouterIntegrationDBTest()
        {
            _server = TestServer.Create<StartupDB>();
        }

        [ClassCleanup()]
        public static void TearDown()
        {
            _server.Dispose();
        }


        //void CadastrarScouter(Scouter scouter);
        //IEnumerable<Scouter> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais);
    }
}
