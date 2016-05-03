using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Tests.ValueObject
{
    [TestClass]
    public class EmailTest
    {

    public const string EMAIL_VALIDO = "me.imagine.debby@gmail.com";


        public static  Email CriarEmailValido()
        {
            return new Email(EMAIL_VALIDO);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Em_Branco()
        {
            var email = new Email("");
            Assert.Fail("Email não pode estar em branco");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Null()
        {
            var email = new Email(null);
            Assert.Fail("Email não pode ser nulo");
        }

        [TestMethod]
        public void Email_New_Email_Valido()
        {
            var endereco = "angeloocana@gmail.com";
            var email = new Email(endereco);
            Assert.AreEqual(endereco, email.EnderecoDeEmail);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Invalido()
        {
            var email = new Email("sdfgsdbglsdkjbgsdlkgb");
            Assert.Fail("Email Invalido");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Erro_MaxLength()
        {
            var endereco = "angeloocana@gmail.com.br";
            while (endereco.Length < Email.EnderecoMaxLength + 1)
            {
                endereco = endereco + "angeloocana@gmail.com.br";
            }

            new Email(endereco);
        }
    }
}