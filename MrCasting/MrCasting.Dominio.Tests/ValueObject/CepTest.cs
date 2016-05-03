using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.ValueObject;
using System;

namespace MrCasting.Domain.Tests.ValueObject
{
    [TestClass]
    public class CepTest
    {
        public const string CEP_VALIDO = "03014000";

        public static Cep CriarCepValido()
        {
            Cep cep = new Cep(CEP_VALIDO);
            return cep; ;
        }

        [TestMethod]
        public void Cep_Valido()
        {
            var cep = "06414-000";
            var obj = new Cep(cep);
            Assert.AreEqual(cep, obj.CepCod);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cep_InValido()
        {
            var cep = "asfsaf";
            var obj = new Cep(cep);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cep_Embranco()
        {
            string cep = "";
            var Cep = new Cep(cep);
        }

        [TestMethod]
        public void Cep_GetCepFormatado06414000()
        {
            var cep = "06414-000";
            var obj = new Cep(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }

        [TestMethod]
        public void Cep_GetCepFormatado00000000()
        {
            var cep = "00000-000";
            var obj = new Cep(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }

        [TestMethod]
        public void Cep_GetCepFormatado12345678()
        {
            var cep = "12345-678";
            var obj = new Cep(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }
    }
}
