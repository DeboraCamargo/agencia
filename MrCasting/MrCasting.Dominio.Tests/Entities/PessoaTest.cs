using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using MrCasting.Domain.Tests.ValueObject;
using System;


namespace MrCasting.Domain.Tests.Entities
{
    [TestClass]
   public class PessoaTest
    {
        public const string NOME_SUCESSO = "Marcos";
        public const string SOBRENOME_SUCESSO = "Barbosa";
        public static readonly DateTime DATA_NASCIMENTO_VALIDA = new DateTime(1989, 01, 07);
        public static readonly Genero GENERO_PADRAO = Genero.Feminino;


        public static Pessoa CriarPessoaSucesso()
        {
            return new Pessoa(NOME_SUCESSO, SOBRENOME_SUCESSO, DATA_NASCIMENTO_VALIDA 
                ,CpfTest.CriarCPFValido(),GENERO_PADRAO,ContatoTest.CriarContatoValido());
        }


        #region Testes Nome
        [TestMethod]
        public void Pessoa_Nome_Valido()
        {
            var nome = "Debora";
            var Pessoa = new Pessoa(nome,SOBRENOME_SUCESSO,DATA_NASCIMENTO_VALIDA,CpfTest.CriarCPFValido(),GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.AreEqual(nome, Pessoa.Nome);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Nome_Exception_Se_Campo_Com_Numeros()
        {
            var nome = "Deb0r4";
            var Pessoa = new Pessoa(nome, SOBRENOME_SUCESSO, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Nome da pessoa não pode conter numeros");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Nome_Exception_Se_Campo_Com_Caracteres_Especiais()
        {
            var nome = "P!nk";
            var Pessoa = new Pessoa(nome, SOBRENOME_SUCESSO, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Nome da pessoa não pode conter caracteres especiais");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Nome_Exception_Se_Nulo_()
        {
            string nome = null;
            var Pessoa = new Pessoa(nome, SOBRENOME_SUCESSO, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Nome não pode ser nulo");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Nome_Exception_Se_Vazio_()
        {
            string nome = "";
            var Pessoa = new Pessoa(nome, SOBRENOME_SUCESSO, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Nome não pode ser vazio");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Nome_Artistico_Exception_Se_Espaco_()
        {
            string nome = "Maria Camargo";
            var Pessoa = new Pessoa(nome, SOBRENOME_SUCESSO, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Nome não pode conter espaço");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessooa_Nome_Exception_Se_Ultrapassar_Max_Lengh()
        {
            string nome = "CamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargo";
            var Pessoa = new Pessoa(nome, SOBRENOME_SUCESSO, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Nome não pode conter mais que 60 caracteres");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Nome_Exception_Se_Abaixo_Mix_Lengh()
        {
            string nome = "A";
            var Pessoa = new Pessoa(nome, SOBRENOME_SUCESSO, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Nome  não pode conter menos que 2 caracter");
        }
        #endregion

        #region Testes sobrenome
        [TestMethod]
        public void Pessoa_Sobrenome_Valido()
        {
            var sobrenome = "Barbosa";
            var Pessoa = new Pessoa(NOME_SUCESSO, sobrenome, DATA_NASCIMENTO_VALIDA, CpfTest.CriarCPFValido(), GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.AreEqual(sobrenome, Pessoa.SobreNome);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Sobrenome_Exception_Se_Campo_Com_Numeros()
        {
            var sobrenome = "C4m27g0";
            var Pessoa = new Pessoa(NOME_SUCESSO, sobrenome, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Sobrenome não pode conter numeros");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Sobrenome_Exception_Se_Campo_Com_Caracteres_Especiais()
        {
            var sobrenome = "P!nk";
            var Pessoa = new Pessoa(NOME_SUCESSO, sobrenome, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Sobrenome não pode conter caracteres especiais");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Sobrenome_Exception_Se_Nulo_()
        {
            string sobrenome = null;
            var Pessoa = new Pessoa(NOME_SUCESSO, sobrenome, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Sobrenome não pode ser nulo");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Sobrenome_Exception_Se_Vazio_()
        {
            string sobrenome = "";
            var Pessoa = new Pessoa(NOME_SUCESSO, sobrenome, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Sobrenome não pode ser vazio");
        }

        [TestMethod]
        public void Pessoa_Sobrenome__Valido_Se_Espaco_()
        {
            string sobrenome = "Barbosa Silva Camargo";
            var Pessoa = new Pessoa(NOME_SUCESSO, sobrenome, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.AreEqual(sobrenome, Pessoa.SobreNome);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Sobrenome_Exception_Se_Ultrapassar_Max_Lengh()
        {
            string sobrenome = "CamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargo";
            var Pessoa = new Pessoa(NOME_SUCESSO, sobrenome, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("SobreNome não pode conter mais que 60 caracteres");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Sobrenome_Exception_Se_Abaixo_Mix_Lengh()
        {
            string sobrenome = "";
            var Pessoa = new Pessoa(NOME_SUCESSO, sobrenome, DATA_NASCIMENTO_VALIDA,  CpfTest.CriarCPFValido(),  GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("SobreNome não pode conter menos que 2 caracteres");
        }
        #endregion

        #region Testes data de nascimento
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Data_Nascimento_Nula_Exception()
        {
            DateTime nascimento = DateTime.MinValue;
            var Pessoa = new Pessoa(NOME_SUCESSO, SOBRENOME_SUCESSO, nascimento, CpfTest.CriarCPFValido(), GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Data de nascimento deve conter algum valor");

        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Data_Nascimento_Vazia_Exception()
        {
            DateTime nascimento = new DateTime();
            var Pessoa = new Pessoa(NOME_SUCESSO, SOBRENOME_SUCESSO, nascimento, CpfTest.CriarCPFValido(), GENERO_PADRAO, ContatoTest.CriarContatoValido());
            Assert.Fail("Data nascimento não pode ser vazia");
        }

          [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Data_Nascimento_Depois_Da_Data_Atual_Exception()
        {
            DateTime nascimento = DateTime.Today.AddDays(1);
            var Pessoa = new Pessoa(NOME_SUCESSO, SOBRENOME_SUCESSO, nascimento, CpfTest.CriarCPFValido(), GENERO_PADRAO, ContatoTest.CriarContatoValido());


        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Pessoa_Data_Nascimento_Antes_De_1880_Exception()
        {
            DateTime nascimento = new DateTime(1880, 1, 1);
            var Pessoa = new Pessoa(NOME_SUCESSO, SOBRENOME_SUCESSO, nascimento, CpfTest.CriarCPFValido(), GENERO_PADRAO, ContatoTest.CriarContatoValido());

        }

        #endregion






    }
}
