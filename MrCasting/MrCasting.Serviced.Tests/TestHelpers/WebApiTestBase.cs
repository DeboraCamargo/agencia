
using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Services.Controllers;
using MrCasting.Services.Impl;
using System;
using System.Net.Http;
using System.Web.Http.SelfHost;

namespace MrCasting.Services.Tests.TestHelpers
{
    internal class WebApiTestBase
    {
        private HttpSelfHostServer _webServer;
        protected IContainer Container { get; private set; }
        protected ContainerBuilder ContainerBuilder { get; set; }
        protected Uri BaseUri { get; private set; }

        private bool _fiddlerActive = true;

        [TestInitialize]
        public void TestFixtureSetup()
        {
            var client = new HttpClient();
            try
            {
                client.GetAsync("http://ipv4.fiddler/").Wait();
            }
            catch (Exception)
            {
                _fiddlerActive = false;
            }
        }

        [ClassInitialize]
        public virtual void Setup()
        {
            BaseUri = new Uri("http://localhost:3000");
            var config = new HttpSelfHostConfiguration(BaseUri);

            ContainerBuilder = ContainerBuilder ?? new ContainerBuilder();
            ContainerBuilder.RegisterApiControllers(typeof(CandidatoController).Assembly);
            ContainerBuilder.RegisterApiControllers(typeof(CaracteristicasFisicasController).Assembly);
            Container = ContainerBuilder.Build();

            RouteConfig.RegisterApiRoutes(config);
            config.DependencyResolver = new AutofacWebApiDependencyResolver(Container);

            _webServer = new HttpSelfHostServer(config);
            _webServer.OpenAsync().Wait();
        }

        protected HttpResponse PerformGetTo(string url)
        {
            var client = new HttpClient();
            var response = client.GetAsync((_fiddlerActive ? "http://ipv4.fiddler:3000/" : BaseUri.ToString()) + url).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            return new HttpResponse { Content = content, Response = response };
        }

        [TestCleanup]
        public void Teardown()
        {
            _webServer.CloseAsync().Wait();
            _webServer.Dispose();
            Container.Dispose();
            ContainerBuilder = null;
            Container = null;
        }   
    }

    class HttpResponse
    {
        public string Content { get; set; }
        public HttpResponseMessage Response { get; set; }
    }
}
