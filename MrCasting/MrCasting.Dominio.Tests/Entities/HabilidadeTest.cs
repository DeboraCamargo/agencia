using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Entities;
using System;

namespace MrCasting.Domain.Tests.Entities
{
    [TestClass]
   public class HabilidadeTest
    {

        public const string NOME_HABILIDADE_VALIDA = "Circense";
        //public const string DESCRICA0_HABILIDADE_VALIDA = "Sei andar de monocleta e tirar coelho da cartola";

        #region Testes nome da habilidade
        [TestMethod]
        public void Habilidade_Valida()
        {
            var nomeHabilidade = NOME_HABILIDADE_VALIDA;
            var Habilidade = new Habilidade(nomeHabilidade);
            Habilidade.NomeHabilidade = nomeHabilidade;
            Assert.AreEqual(nomeHabilidade, Habilidade.NomeHabilidade);
        }


        [TestMethod]
        public void Habilidade_Nome_com_Numero()
        {
            var nomeHabilidade = "P8dalar123";
            var Habilidade = new Habilidade(nomeHabilidade);
            Habilidade.NomeHabilidade = nomeHabilidade;
            Assert.AreEqual(nomeHabilidade, Habilidade.NomeHabilidade);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Habilidade_Nome_Caracteres_Especiais_Exception()
        {
            var nomeHabilidade = "Cor***r";
            var Habilidade = new Habilidade(nomeHabilidade);
            Habilidade.NomeHabilidade = nomeHabilidade;
            Assert.Fail("Nome da habilidade não pode conter caracter especial");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
       public void Habilidade_Nome_Nulo()
        {
            string nomeHabilidade = null;
            var Habilidade = new Habilidade(nomeHabilidade);
            Habilidade.NomeHabilidade = nomeHabilidade;
            Assert.Fail("Nome da habilidade não pode conter caracter especial");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Habilidade_Nome_vazio()
        {
            string nomeHabilidade = "";
            var Habilidade = new Habilidade(nomeHabilidade);
            Habilidade.NomeHabilidade = nomeHabilidade;
            Assert.Fail("Nome da habilidade não pode conter caracter especial");
        }

        [TestMethod]
        public void Habilidade_Nome_Espaco()
        {
            string nomeHabilidade = "Corrida Aquatica";
            var Habilidade = new Habilidade(nomeHabilidade);
            Habilidade.NomeHabilidade = nomeHabilidade;
            Assert.AreEqual(nomeHabilidade, Habilidade.NomeHabilidade);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Habilidade_Nome_Exception_Se_Ultrapassar_Max_Lengh()
        {
            var nomeHabilidade = "Habilidada somente pode contar até trinta caracteres vc acha isso certo joao";
            var Habilidade = new Habilidade(nomeHabilidade);
            Habilidade.NomeHabilidade = nomeHabilidade;
            Assert.Fail("Nome da habilidade não pode conter mais que 30 caracteres");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Habilidade_Nome_Exception_Se_Abaixo_Mix_Lengh()
        {
            var nomeHabilidade = "Cor";
            var Habilidade = new Habilidade(nomeHabilidade);
            Habilidade.NomeHabilidade = nomeHabilidade;
            Assert.Fail("Nome da habilidade não pode conter menos que 4 caracteres");
        }
        #endregion

        #region Testes Descricao Habilidade
        //[TestMethod]

        //public void Habilidade_Descricao_Habilidade_Valida()
        //{
        //    var descricao = DESCRICA0_HABILIDADE_VALIDA;
        //    var Habilidade = new Habilidade(NOME_HABILIDADE_VALIDA);
        //    Habilidade.DescricaoHabilidade = descricao;
        //    Assert.AreEqual(descricao, Habilidade.DescricaoHabilidade);
        //}


        //[TestMethod]
        //public void Habilidade_Descricao_Habilidade_com_Numero_Exception()
        //{
        //    var descricao = "P8dalar123";
        //    var Habilidade = new Habilidade(NOME_HABILIDADE_VALIDA);
        //    Habilidade.DescricaoHabilidade = descricao;
        //    Assert.AreEqual(descricao, Habilidade.DescricaoHabilidade);

        //}

        //[TestMethod]
        //public void Habilidade_Descricao_Habilidade_Caracteres_Especiais()
        //{
        //    var descricao = "Cor***r";
        //    var Habilidade = new Habilidade(NOME_HABILIDADE_VALIDA);
        //    Habilidade.DescricaoHabilidade = descricao;
        //    Assert.AreEqual(descricao, Habilidade.DescricaoHabilidade);
        //}

        //[TestMethod]
        //public void Habilidade_Descricao_Habilidade_Nulo()
        //{
        //    string descricao = null;
        //    var Habilidade = new Habilidade(NOME_HABILIDADE_VALIDA);
        //    Habilidade.DescricaoHabilidade = descricao;
        //    Assert.AreEqual(descricao, Habilidade.DescricaoHabilidade);

        //}

        //[TestMethod]
        //public void Habilidade_Descricao_Habilidade_vazio()
        //{
        //    string descricao = "";
        //    var Habilidade = new Habilidade(NOME_HABILIDADE_VALIDA);
        //    Habilidade.DescricaoHabilidade = descricao;
        //    Assert.AreEqual(descricao, Habilidade.DescricaoHabilidade);
        //}

        //[TestMethod]
        //public void Habilidade_Descricao_Habilidade_Espaco()
        //{
        //    string descricao = "Corrida Aquatica";
        //    var Habilidade = new Habilidade(NOME_HABILIDADE_VALIDA);
        //    Habilidade.DescricaoHabilidade = descricao;
        //    Assert.AreEqual(descricao, Habilidade.DescricaoHabilidade);
        //}

        //[ExpectedException(typeof(Exception))]
        //[TestMethod]
        //public void Habilidade_Descricao_Habilidade_Exception_Se_Ultrapassar_Max_Lengh()
        //{
        //    var descricao = "Habilidada somente pode contar até trinta caracteres vc acha isso certo joao mais uma vez Habilidada somente pode contar até trinta caracteres vc acha isso certo joao";
        //    var Habilidade = new Habilidade(NOME_HABILIDADE_VALIDA);
        //    Habilidade.DescricaoHabilidade = descricao;
        //    Assert.Fail("Descricao da habilidade não pode conter mais que 120 caracteres");
        //}

        //[ExpectedException(typeof(Exception))]
        //[TestMethod]
        //public void Habilidade_Descricao_Habilidade_Exception_Se_Abaixo_Mix_Lengh()
        //{
        //    var descricao = "Cor";
        //    var Habilidade = new Habilidade(NOME_HABILIDADE_VALIDA);
        //    Habilidade.DescricaoHabilidade = descricao;
        //    Assert.Fail("Descricao da habilidade não pode conter menos que 4 caracteres");
        //}
        #endregion


    }
}
