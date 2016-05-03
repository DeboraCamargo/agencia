using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using MrCasting.Domain.DTO;
using System;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Testing.Helpers.EntitiesSamples;

namespace MrCasting.Domain.Tests.Entities
{
    [TestClass]
    public class CandidatoTest
    {
        public const string NOME_FANTASIA_CORRETO = "Debora";
        public const string REALISE_VALIDO_200_BYTES = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis et porttitor orci, quis laoreet elit. Nunc pretium non ante ac varius. In commodo, ex eu tincidunt posuere, metus ipsum vehicula volutpat. ";
        public const string REALISE_INVALIDO_1001_BYTES = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum pretium tellus id nunc ultricies, quis cursus elit imperdiet. Vestibulum sollicitudin tristique mi et mollis. Phasellus a laoreet nunc. Nunc mollis id nulla nec sollicitudin. Vivamus eget vestibulum eros. Ut tristique tempus porttitor. Proin in arcu vitae dui fringilla egestas. Donec vulputate feugiat suscipit. Pellentesque tincidunt urna ut fringilla molestie. Ut tempus felis sit amet ornare varius. In gravida tortor nec dui fermentum, sed accumsan neque pellentesque. Donec pharetra dui eu enim bibendum pulvinar. Proin a mollis mauris. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Fusce neque erat, accumsan nec nibh id, imperdiet euismod augue. Sed vitae lectus sed ex laoreet consectetur.Nullam eget risus eleifend, posuere nulla sit amet, feugiat ipsum.Donec eu erat condimentum, cursus leo ut, tincidunt urna. Vestibulum ante ipsum primis in faucibus orci luctus et metus..";

        #region Testes Nome Artistico
        [TestMethod]
        public void Canditato_Nome_Artistico_Valido()
        {
            var nomeFantasia = "Debora";
            var Candidato = new Candidato(PessoaTest.CriarPessoaSucesso(), nomeFantasia,InteresseSamples.CreateInteresseAtor(0));
            Assert.AreEqual(nomeFantasia, Candidato.NomeFantasia);
        }

        [TestMethod]
        public void Canditato_Nome_Artistico_Valido_Campo_Com_Numeros()
        {
            var nomeFantasia = "Deb0r4";
            var Candidato = new Candidato(PessoaTest.CriarPessoaSucesso(), nomeFantasia, InteresseSamples.CreateInteresseAtor(0));
            Assert.AreEqual(nomeFantasia, Candidato.NomeFantasia);
        }

        [TestMethod]
        public void Canditato_Nome_Artistico_Valido_Campo_Com_Caracteres_Especiais()
        {
            var nome = "P!nk";
            var Candidato = new Candidato(PessoaTest.CriarPessoaSucesso(), nome, InteresseSamples.CreateInteresseAtor(0));
            Assert.AreEqual(nome, Candidato.NomeFantasia);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Nome_Artistico_Exception_Se_Nulo_()
        {
            string nome = null;
            var Candidato = new Candidato(PessoaTest.CriarPessoaSucesso(), nome, InteresseSamples.CreateInteresseAtor(0));
            Assert.Fail("Nome Artistico não pode ser nulo");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Nome_Artistico_Exception_Se_Vazio_()
        {
            string nome = "";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), nome, InteresseSamples.CreateInteresseAtor(0));
            Assert.Fail("Nome Artistico não pode ser vazio");
        }

        [TestMethod]
        public void Canditato_Nome_Artistico_Exception_Se_Espaco_()
        {
            string nome = "Maria Camargo";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), nome, InteresseSamples.CreateInteresseAtor(0));
            Assert.AreEqual(nome, Candidato.NomeFantasia);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Nome_Artistico_Exception_Se_Ultrapassar_Max_Lengh()
        {
            string nome = "CamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargo";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), nome, InteresseSamples.CreateInteresseAtor(0));
            Assert.Fail("Nome Artistico não pode conter mais que 60 caracteres");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Nome_Artistico_Exception_Se_Abaixo_Mix_Lengh()
        {
            string nome = "";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), nome, InteresseSamples.CreateInteresseAtor(0));
            Assert.Fail("Nome Artistico não pode conter menos que 2 caracter");
        }

        #endregion

        #region Testes Sobrenome Artistico
        //[TestMethod]
        //public void Canditato_Sobrenome_Artistico_Valido()
        //{
        //    var sobrenomeFantasia = "Barbosa";
        //    var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, sobrenomeFantasia);
        //    Assert.AreEqual(sobrenomeFantasia, Candidato.SobrenomeFantasia);
        //}

        //[TestMethod]
        //public void Canditato_Sobrenome_Artistico_Valido_Campo_Com_Numeros()
        //{
        //    var sobrenomeFantasia = "C4m27g0";
        //    var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, sobrenomeFantasia);
        //    Assert.AreEqual(sobrenomeFantasia, Candidato.SobrenomeFantasia);
        //}

        //[TestMethod]
        //public void Canditato_Sobrenome_Artistico_Valido_Campo_Com_Caracteres_Especiais()
        //{
        //    var sobrenomeFantasia = "P!nk";
        //    var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, sobrenomeFantasia);
        //    Assert.AreEqual(sobrenomeFantasia, Candidato.SobrenomeFantasia);
        //}

  
        //[TestMethod]
        //public void Canditato_Sobrenome_Artistico_Exception_Se_Nulo_()
        //{
        //    string sobrenomeFantasia = null;
        //    var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, sobrenomeFantasia);
        //    Assert.AreEqual(sobrenomeFantasia, Candidato.SobrenomeFantasia);
        //}

        //[TestMethod]
        //public void Canditato_Sobrenome_Artistico_Exception_Se_Vazio_()
        //{
        //    string sobrenomeFantasia = "";
        //    var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, sobrenomeFantasia);
        //    Assert.AreEqual(sobrenomeFantasia, Candidato.SobrenomeFantasia);
        //}

        //[TestMethod]
        //public void Canditato_Sobrenome_Artistico_Exception_Se_Espaco_()
        //{
        //    string sobrenomeFantasia = "Barbosa Silva Camargo";
        //    var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, sobrenomeFantasia);
        //    Assert.AreEqual(sobrenomeFantasia, Candidato.SobrenomeFantasia);
        //}

        //[ExpectedException(typeof(Exception))]
        //[TestMethod]
        //public void Canditato_Sobrenome_Artistico_Exception_Se_Ultrapassar_Max_Lengh()
        //{
        //    string sobrenomeFantasia = "CamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargoCamargo";
        //    var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, sobrenomeFantasia);
        //    Assert.Fail("SobreNome Artistico não pode conter mais que 60 caracteres");
        //}
    
        #endregion

        #region Testes Profissao
        [TestMethod]
        public void Canditato_Campo_Profissao_Valido()
        {
            var profissao = "Medico";
            var Candidato = new Candidato(PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Profissao = profissao;
            Assert.AreEqual(profissao, Candidato.Profissao);
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Profissao_Campo_Com_Numeros()
        {
            var profissao = "En5enheir0";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Profissao = profissao;
            Assert.Fail("Campo profissão nao pode conter numeros");

        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Profissao_Campo_Com_Caracteres_Especiais()
        {
            var profissao = "P!nt*r";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Profissao = profissao;
            Assert.Fail("Campo profissão nao pode conter caracteres especiais");
        }

        [TestMethod]
        public void Canditato_Campo_Profissao_Se_Nulo_()
        {
            string profissao = null;
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Profissao = profissao;
            Assert.AreEqual(profissao, Candidato.Profissao);
        }

        [TestMethod]
        public void Canditato_Campo_Profissao_Se_Vazio_()
        {
            var profissao = "";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Profissao = profissao;
            Assert.AreEqual(profissao, Candidato.Profissao);
        }

        [TestMethod]
        public void Canditato_Campo_Profissao_Exception_Se_Espaco_()
        {
            var profissao = "Engenheiro de Software";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Profissao = profissao;
            Assert.AreEqual(profissao, Candidato.Profissao);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Profissao_Exception_Se_Ultrapassar_Max_Lengh()
        {
            string profissao = "Engenheiro de software compatibilizado com testes de maquina virtual vmware e redes com banco de dados";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Profissao = profissao;
            Assert.Fail("Campo profissão nao pode conter mais que 60 caracteres");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Profissao_Exception_Se_Abaixo_Mix_Lengh()
        {
            string profissao = "E";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Profissao = profissao;
            Assert.Fail("Campo profissão nao pode conter menos que 2 caracteres");
        }

        #endregion

        #region Testes Realise
        [TestMethod]
        public void Canditato_Campo_Realise_Valido()
        {
            var realise = REALISE_VALIDO_200_BYTES;
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Realise = realise;
            Assert.AreEqual(realise, Candidato.Realise);
        }

        [TestMethod]
        public void Canditato_Campo_Realise_Campo_Com_Numeros()
        {
            var realise = "L0ren ipsum";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Realise = realise;
            Assert.AreEqual(realise, Candidato.Realise);
        }

        [TestMethod]
        public void Canditato_Campo_Realise_Campo_Com_Caracteres_Especiais()
        {
            var realise = "Loren !psum";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Realise = realise;
            Assert.AreEqual(realise, Candidato.Realise);
        }

        [TestMethod]
        public void Canditato_Campo_Realise_Se_Nulo_()
        {
            string realise = null;
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Realise = realise;
            Assert.AreEqual(realise, Candidato.Realise);
        }

        [TestMethod]
        public void Canditato_Campo_Realise_Se_Vazio_()
        {
            string realise = "";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Realise = realise;
            Assert.AreEqual(realise, Candidato.Realise);
        }

        [TestMethod]
        public void Canditato_Campo_Realise_Se_Espaco_()
        {
            string realise = REALISE_VALIDO_200_BYTES;
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Realise = realise;
            Assert.AreEqual(realise, Candidato.Realise);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Realise_Exception_Se_Ultrapassar_Max_Lengh()
        {
            string realise = REALISE_INVALIDO_1001_BYTES;
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Realise = realise;
            Assert.Fail("Campo realise nao pode conter mais que 1000 caracteres");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Realise_Exception_Se_Abaixo_Mix_Lengh()
        {
            string realise = "Loren";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Realise = realise;
            Assert.Fail("Campo realise nao pode conter menos que 10 caracteres");
        }

        #endregion

        #region Testes Naturalidade
        [TestMethod]
        public void Canditato_Campo_Naturalidade_Valido()
        {
            var naturalidade = "paulistana";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Naturalidade = naturalidade;
            Assert.AreEqual(naturalidade, Candidato.Naturalidade);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Naturalidade_Campo_Com_Numeros()
        {
            var naturalidade = "paulistan0";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Naturalidade = naturalidade;
            Assert.Fail("Naturalidade não pode conter numeros");
        }


        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Naturalidade_Campo_Com_Caracteres_Especiais()
        {
            var naturalidade = "paul!stano";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Naturalidade = naturalidade;
            Assert.Fail("Naturalidade não pode conter caracteres especiais");
        }

        [TestMethod]
        public void Canditato_Campo_Naturalidade_Se_Nulo_()
        {
            string naturalidade = null;
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Naturalidade = naturalidade;
            Assert.AreEqual(naturalidade, Candidato.Naturalidade);
        }

        [TestMethod]
        public void Canditato_Campo_Naturalidade_Se_Vazio_()
        {
            var naturalidade = "";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Naturalidade = naturalidade;
            Assert.AreEqual(naturalidade, Candidato.Naturalidade);
        }

        [TestMethod]
        public void Canditato_Campo_Naturalidade_Se_Espaco_()
        {
            var naturalidade = "espinosa MG";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Naturalidade = naturalidade;
            Assert.AreEqual(naturalidade, Candidato.Naturalidade);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Naturalidade_Exception_Se_Ultrapassar_Max_Lengh()
        {
            var naturalidade = "paulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistana";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Naturalidade = naturalidade;
            Assert.Fail("Campo naturalidade nao pode conter mais que 120 caracteres");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Naturalidade_Exception_Se_Abaixo_Mix_Lengh()
        {
            var naturalidade = "p";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Naturalidade = naturalidade;
            Assert.AreEqual(naturalidade, Candidato.Naturalidade);
            Assert.Fail("Campo naturalidade nao pode conter menos que 2 caracteres");
        }
        #endregion

        #region Testes Nacionalidade
        [TestMethod]
        public void Canditato_Campo_Nacionalidade_Valido()
        {
            var nacionalidade = "paulistana";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Nacionalidade = nacionalidade;
            Assert.AreEqual(nacionalidade, Candidato.Nacionalidade);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Nacionalidade_Campo_Com_Numeros()
        {
            var nacionalidade = "paulistan0";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Naturalidade = nacionalidade;
            Assert.Fail("Nacionalidade não pode conter numeros");
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Nacionalidade_Campo_Com_Caracteres_Especiais()
        {
            var nacionalidade = "paul!stano";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Nacionalidade = nacionalidade;
            Assert.Fail("Nacionalidade não pode conter caracteres especiais");
        }

        [TestMethod]
        public void Canditato_Campo_Nacionalidade_Se_Nulo_()
        {
            string nacionalidade = null;
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Nacionalidade = nacionalidade;
            Assert.AreEqual(nacionalidade, Candidato.Nacionalidade);
        }

        [TestMethod]
        public void Canditato_Campo_Nacionalidade_Se_Vazio_()
        {
            var nacionalidade = "";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Nacionalidade = nacionalidade;
            Assert.AreEqual(nacionalidade, Candidato.Nacionalidade);
        }

        [TestMethod]
        public void Canditato_Campo_Nacionalidade_Se_Espaco_()
        {
            var nacionalidade = "espinosa MG";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Nacionalidade = nacionalidade;
            Assert.AreEqual(nacionalidade, Candidato.Nacionalidade);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Nacionalidade_Exception_Se_Ultrapassar_Max_Lengh()
        {
            var nacionalidade = "paulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistanapaulistana";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Nacionalidade = nacionalidade;
            Assert.Fail("Campo nacionalidade nao pode conter mais que 120 caracteres");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Canditato_Campo_Nacionalidade_Exception_Se_Abaixo_Mix_Lengh()
        {
            var nacionalidade = "p";
            var Candidato = new Candidato( PessoaTest.CriarPessoaSucesso(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0));
            Candidato.Nacionalidade = nacionalidade;
            Assert.Fail("Campo nacionalidade nao pode conter menos que 2 caracteres");
        }

        #endregion

    }
}
