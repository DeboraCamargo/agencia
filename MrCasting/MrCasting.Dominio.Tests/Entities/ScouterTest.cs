using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Entities;
using MrCasting.Testing.Helpers.EntitiesSamples;
using System;

namespace MrCasting.Domain.Tests.Entities
{

    [TestClass]
    public  class ScouterTest
    {

        [TestMethod]
        public void Scouter_CNPJ_Valido()
        {
            string cnpj = "17.476.845/0001-50";
            var scouter = new Scouter(1,PessoaSamples.CreatePessoa(),cnpj);
            scouter.Cnpj = cnpj;
            Assert.AreEqual(cnpj, scouter.Cnpj);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Scouter_CNPJ_Invalido()
        {
            string cnpj = "17.476.845/0001-52";
            var scouter = new Scouter(1, PessoaSamples.CreatePessoa(), cnpj);
            scouter.Cnpj = cnpj;
            Assert.Fail("Cnpj Inválido");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Scouter_CNPJ_MaxLenght()
        {
            string cnpj = "17.476.845/0001-5000";
            var scouter = new Scouter(1, PessoaSamples.CreatePessoa(), cnpj);
            scouter.Cnpj = cnpj;
            Assert.Fail("Tamanho máximo cnpj atingido");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Scouter_CNPJ_MinLenght()
        {
            string cnpj = "17.476.845/01-50";
            var scouter = new Scouter(1, PessoaSamples.CreatePessoa(), cnpj);
            scouter.Cnpj = cnpj;
            Assert.Fail("Tamanho máximo cnpj atingido");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Scouter_CNPJ_OutrosCaracteres()
        {
            string cnpj = "17.476.845/01-50*";
            var scouter = new Scouter(1, PessoaSamples.CreatePessoa(), cnpj);
            scouter.Cnpj = cnpj;
            Assert.Fail("CNJP Com caracteres especiais fora do esperado");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Scouter_CNPJ_Espaço()
        {
            string cnpj = "17.476.84 5/01-50";
            var scouter = new Scouter(1, PessoaSamples.CreatePessoa(), cnpj);
            scouter.Cnpj = cnpj;
            Assert.Fail("CNJP contém espaços fora do esperado");
        }

    }
}
