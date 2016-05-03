using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Repositories;

namespace MrCasting.Infra.Data.Tests.Repositories
{
    [TestClass]
    public class ContatoRepositoryTests
    {

        private static IContatoRepository _contatoRepository;

        public ContatoRepositoryTests()
        {
            _contatoRepository = new ContatoRepository(new Infra.Data.Contexts.GeneralContext());
        }

        [ClassCleanup()]
        public static void TearDown()
        {
            _contatoRepository.Dispose();
        }

    }
}
