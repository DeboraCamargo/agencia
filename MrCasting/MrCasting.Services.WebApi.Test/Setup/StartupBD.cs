using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System.Reflection;
using MrCasting.Domain.Interfaces.Services;
using MrCasting.Domain.Services;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Repositories;
using MrCasting.Infra.Data.Contexts;
using MrCasting.Domain.Interfaces.Application;
using System.Web.Http;
using MrCasting.Application.Impl;

namespace MrCasting.Services.WebApi.Test.Setup
{
    public class StartupDB : StartupBase
    {

        public void Configuration(IAppBuilder appBuilder)
        {
            var config = GetConfiguration();

            appBuilder.UseNinjectMiddleware(CreateKernel).UseNinjectWebApi(config);
            appBuilder.UseWebApi(config).UseNancy();

            GlobalConfiguration.Configuration.IncludeErrorDetailPolicy
                = IncludeErrorDetailPolicy.Always;
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
    }
}
