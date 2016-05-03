using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.ValueObject;
using System;

namespace MrCasting.Domain.Tests.ValueObject
{
    [TestClass]
    public class CpfTest
    {
        public const string CPF_VALIDO = "33550028873";

        public static Cpf CriarCPFValido()
        {
            return new Cpf(CPF_VALIDO);
        }

        [TestMethod]
        public void Cpf_New_Cpf_Valido_40914294830()
        {
            var cpf = new Cpf("409.142.948-30");
            Assert.AreEqual(40914294830, cpf.Codigo);
            Assert.AreEqual("40914294830", cpf.GetCpfCompleto());
            Assert.AreEqual("40914294830", cpf.GetSemZeros());
        }

        [TestMethod]
        public void Cpf_New_Cpf_Valido_02766657401()
        {
            var cpf = new Cpf("027.666.574-01");
            Assert.AreEqual(2766657401, cpf.Codigo);
            Assert.AreEqual("02766657401", cpf.GetCpfCompleto());
            Assert.AreEqual("2766657401", cpf.GetSemZeros());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cpf_New_Cpf_Invalido_0d89502b3454e()
        {
            var cpf = new Cpf("0d89502b3454e");
        }
    }
}