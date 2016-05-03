[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MrCasting.Services.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(MrCasting.Services.App_Start.NinjectWebCommon), "Stop")]

namespace MrCasting.Services.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Domain.Interfaces.Services;
    using Domain.Interfaces.Repositories;
    using Infra.Data.Repositories;
    using Infra.Data.Contexts;
    using System.Web.Http;
    using Domain.Services;
    using Domain.Interfaces.Application;
    using Application.Impl;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            // Application
            kernel.Bind(typeof(ICandidatoAppService)).To(typeof(CandidatoAppService));
            kernel.Bind(typeof(IContatoAppService)).To(typeof(ContatoAppService));
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind(typeof(ICaracteristicasFisicasAppService)).To(typeof(CaracteristicasFisicasAppService));
            kernel.Bind(typeof(ITagsAppService)).To(typeof(TagsAppService));
            kernel.Bind(typeof(IHobbyAppService)).To(typeof(HobbyAppService));
            kernel.Bind(typeof(IHabilidadeAppService)).To(typeof(HabilidadeAppService));
            kernel.Bind(typeof(IInteresseAppService)).To(typeof(InteresseAppService));
            kernel.Bind(typeof(IPessoaAppService)).To(typeof(PessoaAppService));
            kernel.Bind(typeof(IEnderecoAppService)).To(typeof(EnderecoAppService));
            kernel.Bind(typeof(IVagaAppService)).To(typeof(VagaAppService));
            kernel.Bind(typeof(IPropostaAppService)).To(typeof(PropostaAppService));
            kernel.Bind(typeof(IScouterAppService)).To(typeof(ScouterAppService));
            kernel.Bind(typeof(IVideoAppService)).To(typeof(VideoAppService));
            kernel.Bind(typeof(IFotoAppService)).To(typeof(FotoAppService));
            kernel.Bind(typeof(ILoginOAuthAppService)).To(typeof(LoginOAuthAppService));
            kernel.Bind(typeof(IContaAppService)).To(typeof(ContaAppService));



            // Domain
            kernel.Bind(typeof(ICandidatoService)).To(typeof(CandidatoService));
            kernel.Bind(typeof(IContatoService)).To(typeof(ContatoService));
            kernel.Bind(typeof(ICaracteristicaFisicaService)).To(typeof(CaracteristicaFisicaService));
            kernel.Bind(typeof(ITagsService)).To(typeof(TagsService));
            kernel.Bind(typeof(IHobbyService)).To(typeof(HobbyService));
            kernel.Bind(typeof(IHabilidadeService)).To(typeof(HabilidadeService));
            kernel.Bind(typeof(IInteresseService)).To(typeof(InteresseService));
            kernel.Bind(typeof(IPessoaService)).To(typeof(PessoaService));
            kernel.Bind(typeof(IEnderecoService)).To(typeof(EnderecoService));
            kernel.Bind(typeof(IVagaService)).To(typeof(VagaService));
            kernel.Bind(typeof(IPropostaService)).To(typeof(PropostaService));
            kernel.Bind(typeof(IScouterService)).To(typeof(ScouterService));
            kernel.Bind(typeof(IFotoService)).To(typeof(FotoService));
            kernel.Bind(typeof(IVideoService)).To(typeof(VideoService));
            kernel.Bind(typeof(ILoginOAuthService)).To(typeof(LoginOAuthService));
            kernel.Bind(typeof(IContaService)).To(typeof(ContaService));


            // Data
            kernel.Bind(typeof(ICandidatoRepository)).To(typeof(CandidatoRepository));
            kernel.Bind(typeof(IContatoRepository)).To(typeof(ContatoRepository));
            kernel.Bind(typeof(ICaracteristicaFisicaRepository)).To(typeof(CaracteristicaFisicaRepository));
            kernel.Bind(typeof(ITagsRepository)).To(typeof(TagRepository));
            kernel.Bind(typeof(IHobbyRepository)).To(typeof(HobbyRepository));
            kernel.Bind(typeof(IHabilidadeRepository)).To(typeof(HabilidadeRepository));
            kernel.Bind(typeof(IInteresseRepository)).To(typeof(InteresseRepository));
            kernel.Bind(typeof(IPessoaRepository)).To(typeof(PessoaRepository));
            kernel.Bind(typeof(IEnderecoRepository)).To(typeof(EnderecoRepository));

            kernel.Bind(typeof(IVagaRepository)).To(typeof(VagaRepository));
            kernel.Bind(typeof(IPropostaRepository)).To(typeof(PropostaRepository));
            kernel.Bind(typeof(IScouterRepository)).To(typeof(ScouterRepository));
            kernel.Bind(typeof(IFotoRepository)).To(typeof(FotoRepository));
            kernel.Bind(typeof(IVideoRepository)).To(typeof(VideoRepository));
            kernel.Bind(typeof(ILoginOAuthRepository)).To(typeof(LoginOAuthRepository));
            kernel.Bind(typeof(IContaRepository)).To(typeof(ContaRepository));


            // Context
            kernel.Bind(typeof(GeneralContext)).To(typeof(GeneralContext));
        }

        public static void RegisterNinject(HttpConfiguration configuration)
        {
            // Set Web API Resolver
            configuration.DependencyResolver = new NinjectDependencyResolver(new Bootstrapper().Kernel);

        }
    }
}
