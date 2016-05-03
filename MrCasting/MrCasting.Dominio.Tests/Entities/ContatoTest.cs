using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Tests.ValueObject;
using MrCasting.Domain.ValueObject;
using System;

namespace MrCasting.Domain.Tests.Entities
{
    [TestClass]
    public class ContatoTest
    {

        public static readonly Email EMAIL_VALIDO = new Email("angeloocana@gmail.com");
        public static readonly Telefone TELEFONE_VALIDO = new Telefone("011", "985424740");

        public static Contato CriarContatoValido()
        {
            return new Contato(EmailTest.CriarEmailValido(),TelefoneTest.CriarTelefoneValido());
           
        }

    }
}
