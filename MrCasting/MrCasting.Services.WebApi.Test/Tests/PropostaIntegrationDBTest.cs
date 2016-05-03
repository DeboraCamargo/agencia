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
   public class PropostaIntegrationDBTest
    {
        private static TestServer _server;
        private static IPropostaRepository propostaRepository = new PropostaRepository(new Infra.Data.Contexts.GeneralContext());

        public PropostaIntegrationDBTest()
        {
            _server = TestServer.Create<StartupDB>();
        }

        [ClassCleanup()]
        public static void TearDown()
        {
            _server.Dispose();
        }


        //void CadastrarProposta(Proposta proposta);
        //IEnumerable<string> ConsultarPropostas(int idScouter);
        //void RemoverProposta(int idProposta);
        //void EditarProposta(Proposta proposta);

    }
}
