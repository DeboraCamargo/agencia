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
   public class TelefoneTest
    {
        public const string DDD_VALIDO = "011";
        public const string NUMERO_VALIDO = "985424740";

        public static Telefone CriarTelefoneValido()
        {
            return new Telefone(DDD_VALIDO, NUMERO_VALIDO);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Telefone_Numero_Em_Branco()
        {
            var numero = "";
            var telefone = new Telefone(numero);
            Assert.Fail("Telefoe não pode estar em branco");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Telefone_Sem_DDD()
        {
            var numero = "985424740";
            var ddd = "";
            var telefone = new Telefone(ddd, numero);
            Assert.Fail("DDD é obrigatório");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Telefone_DDD_Nulo()
        {
            var numero = NUMERO_VALIDO;
            string ddd = null;
            var telefone = new Telefone(ddd, numero);
            Assert.Fail("DDD é obrigatório - não pode ser nulo");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Telefone_Numero_Nulo()
        {
            string numero = null;
            string ddd = DDD_VALIDO;
            var telefone = new Telefone(ddd, numero);
            Assert.Fail("numero é obrigatório - não pode ser nulo");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Telefone_DDD_Sem_Telefone()
        {
            var numero = "";
            var ddd = "011";
            var telefone = new Telefone(ddd, numero);
            Assert.Fail("Telefone é obrigatório e não pode estar em branco");
        }

        [TestMethod]
        public void Telefone_Quantidade_9__Digitos()
        {
            var numero = "985424740";
            var telefone = new Telefone(numero);
            Assert.AreEqual(telefone, telefone.Numero);
        }

        [TestMethod]
        public void Telefone_Quantidade_8__Digitos()
        {
            var numero = "85424740";
            var telefone = new Telefone(numero);
            Assert.AreEqual(telefone, telefone.Numero);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Telefone_Quantidade_Maior_De__Digitos()
        {
            var numero = "85424740095838949059034";
            var telefone = new Telefone(numero);
            Assert.Fail("Quantidade de digitos maxima telefone");
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Telefone_Quantidade_Menor_De__Digitos()
        {
            var numero = "854";
            var telefone = new Telefone(numero);
            Assert.Fail("Quantidade de digitos minima telefone");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Telefone_Invalido()
        {
            var numero = "8983jjkky";
            var telefone = new Telefone(numero);
            Assert.Fail("Caracter telefone invalido");
        }

    }
}
