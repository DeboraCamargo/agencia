using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Services.Tests.TestHelpers;
using Autofac;
using NSubstitute;
using MrCasting.Domain.Entities;
using System.Net;
using MrCasting.Domain.Interfaces.Application;

namespace MrCasting.Services.Tests
{
    [TestClass]
    internal class CandidatoServiceTests : WebApiTestBase
    {
        private ICandidatoAppService service;
        private Candidato candidato;

        public CandidatoServiceTests()
        {
        }

        [ClassInitialize]
        public override void Setup()
        {
            ContainerBuilder = new ContainerBuilder();
            service = Substitute.For<ICandidatoAppService>();
            ContainerBuilder.Register(c => service);
            base.Setup();
        }

        [TestMethod]
        public void CandidatoService_()
        {
            service.When(s => s.CadastrarCandidato(candidato)).Do(s => { });

            var response = PerformGetTo("api/ping");

            Assert.AreEqual(HttpStatusCode.InternalServerError, response.Response.StatusCode);
        }

        [TestMethod]
        public void CandidatoServices_InsertCandidato_EmailJaExiste()
        {
            service.When(s => s.CadastrarCandidato(candidato)).Do(s => { throw new Exception("EmailJaCadastrado"); });
        }
    }
}
