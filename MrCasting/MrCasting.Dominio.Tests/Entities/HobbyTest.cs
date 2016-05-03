using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Tests.Entities
{
    [TestClass]
   public class HobbyTest
    {
        public const string NOME_HOBBY_VALIDA = "Assistir seriados";
        //public const string DESCRICA0_HOBBY_VALIDA = "filmes de terror";

        #region Testes nome da Hobby
        [TestMethod]
        public void Hobby_Valido()
        {
            var nomeHobby = NOME_HOBBY_VALIDA;
            var hobby = new Hobby(nomeHobby);
            hobby.NomeHobby = nomeHobby;
           Assert.AreEqual(nomeHobby, hobby.NomeHobby);
        }

        [TestMethod]
        public void Hobby_Nome_com_Numero()
        {
            var nomeHobby = "P8dalar123";
            var Hobby = new Hobby(nomeHobby);
            Hobby.NomeHobby = nomeHobby;
            Assert.AreEqual(nomeHobby, Hobby.NomeHobby);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Hobby_Nome_Caracteres_Especiais_Exception()
        {
            var nomeHobby = "Cor***r";
            var Hobby = new Hobby(nomeHobby);
            Hobby.NomeHobby = nomeHobby;
            Assert.Fail("Nome da Hobby não pode conter caracter especial");
        }

        [TestMethod]
        public void Hobby_Nome_Nulo()
        {
            string nomeHobby = null;
            var Hobby = new Hobby(nomeHobby);
            Assert.AreEqual(nomeHobby, Hobby.NomeHobby);
        }

        [TestMethod]
        public void Hobby_Nome_vazio()
        {
            string nomeHobby = "";
            var Hobby = new Hobby(nomeHobby);
            Hobby.NomeHobby = nomeHobby;
            Assert.AreEqual(nomeHobby, Hobby.NomeHobby);
        }

        [TestMethod]
        public void Hobby_Nome_Espaco()
        {
            string nomeHobby = "Corrida Aquatica";
            var Hobby = new Hobby(nomeHobby);
            Hobby.NomeHobby = nomeHobby;
            Assert.AreEqual(nomeHobby, Hobby.NomeHobby);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Hobby_Nome_Exception_Se_Ultrapassar_Max_Lengh()
        {
            var Hobby = new Hobby();
            Hobby.NomeHobby = "Habilidada somente pode contar até trinta caracteres vc acha isso certo joao";
            Assert.Fail("Nome da Hobby não pode conter mais que 30 caracteres");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Hobby_Nome_Exception_Se_Abaixo_Mix_Lengh()
        {
            var nomeHobby = "Cor";
            var Hobby = new Hobby();
            Hobby.NomeHobby = nomeHobby;
            Assert.Fail("Nome da Hobby não pode conter menos que 4 caracteres");
        }
        #endregion

        #region Testes Descricao Hobby
        //[TestMethod]
        //public void Hobby_Descricao_Hobby_Valida()
        //{
        //    var descricao = DESCRICA0_HOBBY_VALIDA;
        //    var Hobby = new Hobby(NOME_HOBBY_VALIDA);
        //    Hobby.DescricaoHobby = descricao;
        //    Assert.AreEqual(descricao, Hobby.DescricaoHobby);
        //}


        //[TestMethod]
        //public void Hobby_Descricao_Hobby_com_Numero_Exception()
        //{
        //    var descricao = "P8dalar123";
        //    var Hobby = new Hobby(NOME_HOBBY_VALIDA);
        //    Hobby.DescricaoHobby = descricao;
        //    Assert.AreEqual(descricao, Hobby.DescricaoHobby);
        //}

        //[TestMethod]
        //public void Hobby_Descricao_Hobby_Caracteres_Especiais_Exception()
        //{
        //    var descricao = "Cor***r!";
        //    var Hobby = new Hobby(NOME_HOBBY_VALIDA);
        //    Hobby.DescricaoHobby = descricao;
        //    Assert.AreEqual(descricao, Hobby.DescricaoHobby);
        //}

        //[TestMethod]
        //public void Descricao_Hobby_Nome_Nulo()
        //{
        //    string descricao = null;
        //    var Hobby = new Hobby(NOME_HOBBY_VALIDA);
        //    Hobby.DescricaoHobby = descricao;
        //    Assert.AreEqual(descricao, Hobby.DescricaoHobby);
        //}

        //[TestMethod]
        //public void Hobby_Descricao_Hobby_Nome_vazio()
        //{
        //    string descricao = "";
        //    var Hobby = new Hobby(NOME_HOBBY_VALIDA);
        //    Hobby.DescricaoHobby = descricao;
        //    Assert.AreEqual(descricao, Hobby.DescricaoHobby);
        //}

        //[TestMethod]
        //public void Hobby_Descricao_Hobby_Espaco()
        //{
        //    string descricao = "Corrida Aquatica";
        //    var Hobby = new Hobby(NOME_HOBBY_VALIDA);
        //    Hobby.DescricaoHobby = descricao;

        //    Assert.AreEqual(descricao, Hobby.DescricaoHobby);
        //}

        //[ExpectedException(typeof(Exception))]
        //[TestMethod]
        //public void Hobby_Descricao_Hobby_Exception_Se_Ultrapassar_Max_Lengh()
        //{
        //    var descricao = "Habilidada somente pode contar até trinta caracteres vc acha isso certo joao mais uma vez Habilidada somente pode contar até trinta caracteres vc acha isso certo joao";
        //    var Hobby = new Hobby(NOME_HOBBY_VALIDA);
        //    Hobby.DescricaoHobby = descricao;
        //    Assert.Fail("Descricao da Hobby não pode conter mais que 120 caracteres");
        //}

        //[ExpectedException(typeof(Exception))]
        //[TestMethod]
        //public void Hobby_Descricao_Hobby_Exception_Se_Abaixo_Mix_Lengh()
        //{
        //    var descricao = "Cor";
        //    var Hobby = new Hobby(NOME_HOBBY_VALIDA);
        //    Hobby.DescricaoHobby = descricao;

        //    Assert.Fail("Descricao da Hobby não pode conter menos que 4 caracteres");
        //}
        #endregion


    }
}
