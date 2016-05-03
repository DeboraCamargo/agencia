using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System.Reflection;
using System.Web.Http;
using System;
using MrCasting.Domain.Interfaces.Application;

namespace MrCasting.Services.WebApi.Test.Setup
{
    public class StartupMock : StartupBase
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = GetConfiguration();

            appBuilder.UseNinjectMiddleware(CreateKernel).UseNinjectWebApi(config);
            appBuilder.UseWebApi(config).UseNancy();
        }

        private static StandardKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            RegisterServices(kernel);
            return kernel;
        }

        private static void RegisterServices(IKernel kernel)
        {
            // Application
            kernel.Bind(typeof(ICandidatoAppService)).To(typeof(CandidatoAppServiceMock));
        }
    }
}
