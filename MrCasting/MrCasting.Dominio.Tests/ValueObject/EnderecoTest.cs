using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using System;

namespace MrCasting.Domain.Tests.ValueObject
{
    [TestClass]
    public class EnderecoTest
    {

        public const string LOGRADOURO_SUCESSO = "Avenida Celso Garcia";
        public const string COMPLEMENTO_SUCESSO = "AP 134 BL 18";
        public const string NUMERO_SUCESSO = "1907";
        public const string BAIRRO_SUCESSO = "Tatuapé";
        public const string CIDADE_SUCESSO = "São Paulo";
        public static readonly Uf UF = Uf.SP;


        public static Endereco CriarEnderecoValido()
        {
            return new Endereco(CIDADE_SUCESSO, UF);

        }

        #region Testes Logradouro
        [TestMethod]
        public void ValidarLogradouro_Valido()
        {
            string logradouro = "Rua renascer em cristo";
            var Logradouro = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Logradouro.Logradouro = logradouro;
            Assert.AreEqual(logradouro, Logradouro.Logradouro);

        }

        [TestMethod]
        public void ValidarLogradouro_nulo()
        {
            string logradouro = null;
            var Logradouro = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Logradouro.Logradouro = logradouro;
            Assert.AreEqual(logradouro, Logradouro.Logradouro);
        }

        [TestMethod]
        public void ValidarLogradoura_Vazio()
        {
            string logradouro = "";
            var Logradouro = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Logradouro.Logradouro = logradouro;
            Assert.AreEqual(logradouro, Logradouro.Logradouro);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ValidarLogradouro_MaxLengh()
        {

            string logradouro = "rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua rua ";
            var Logradouro = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Logradouro.Logradouro = logradouro;
            Assert.Fail("Tamanho maximo excedido");
        }

        #endregion

        #region Testes Complemento

        [TestMethod]
        public void ValidarComplemento_Valido()
        {
            string complemento = "Ap 134 bl 18";
            var Complemento = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Complemento.Complemento = complemento;
            Assert.AreEqual(complemento, Complemento.Complemento);
        }
        [TestMethod]
        public void ValidarComplemento_Nulo()
        {
            string complemento = null;
            var Complemento = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Complemento.Complemento = complemento;
            Assert.AreEqual(complemento, Complemento.Complemento);
        }

        [TestMethod]
        public void ValidarComplemento_Vazio()
        {
            string complemento = "";
            var Complemento = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Complemento.Complemento = complemento;
            Assert.AreEqual(complemento, Complemento.Complemento);
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ValidarComplemento_MaxLengh()
        {
            string complemento = "Complemento Complemento Complemento Complemento Complemento Complemento Complemento Complemento Complemento Complemento Complemento Complemento ";
            var Complemento = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Complemento.Complemento = complemento;
            Assert.Fail("Tamanho fora do limite");
        }
        #endregion

        #region Testes Numero
        [TestMethod]
        public void ValidarNumero_Valido()
        {
            string numero = "34 fundos";
            var Numero = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Numero.Numero = numero;
            Assert.AreEqual(numero, Numero.Numero);
        }

        [TestMethod]
        public void ValidarNumero_nulo()
        {
            string numero = null;
            var Numero = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Numero.Numero = numero;
            Assert.AreEqual(numero, Numero.Numero);
        }
        [TestMethod]
        public void ValidarNumero_Vazio()
        {
            string numero = "";
            var Numero = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Numero.Numero = numero;
            Assert.AreEqual(numero, Numero.Numero);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ValidarNumero_MaxLengh()
        {
            string numero = "numero numero numero numero numero numero numero numero numero numero numero numero ";
            var Numero = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Numero.Numero = numero;
            Assert.Fail("Numero excedeu tamanho maximo");
        }

        #endregion

        #region Testes Bairro
        [TestMethod]
        public void ValidarBairro_Vazio()
        {
            string bairro = "";
            var Bairro = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Bairro.Bairro = bairro;
            Assert.AreEqual(bairro, Bairro.Bairro);
        }
        [TestMethod]
        public void ValidarBairro_Nulo()
        {
            string bairro = null;
            var Bairro = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Bairro.Bairro = bairro;
            Assert.AreEqual(bairro, Bairro.Bairro);
        }

        [TestMethod]
        public void ValidarBairro_Valido()
        {
            string bairro = BAIRRO_SUCESSO;
            var Bairro = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Bairro.Bairro = bairro;
            Assert.AreEqual(bairro, Bairro.Bairro);
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ValidarBairro_MaxLengh()
        {
            string bairro = "Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro Bairro BBairro Bairro Bairro Bairro airro Bairro Bairro ";
            var Bairro = new Endereco(CIDADE_SUCESSO, Uf.AC);
            Bairro.Bairro = bairro;
            Assert.Fail("Bairro excedeu tamanho maximo");
        }
        #endregion

        #region Testes Cidade

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ValidarCidade_Vazio()
        {
            string cidade = "";
            var Cidade = new Endereco(cidade, Uf.AC);
            Assert.Fail("Cidade vazia");
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ValidarCidade_Nulo()
        {
            string cidade = "";
            var Cidade = new Endereco(cidade, Uf.AC);
            Assert.Fail("Cidade nula");
        }

        [TestMethod]
        public void ValidarCidade_Valido()
        {
            string cidade = CIDADE_SUCESSO;
            var Cidade = new Endereco(cidade, Uf.AC);
            Assert.AreEqual(cidade, Cidade.Cidade);
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ValidarCidade_MaxLengh()
        {
            string cidade = "Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade Cidade ";
            var Cidade = new Endereco(cidade, Uf.AC);
            Assert.Fail("cidade excedeu tamanho maximo");
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ValidarCidade_Numero()
        {
            string cidade = "São Gonçalo56";
            var Cidade = new Endereco(cidade, Uf.AC);
            Assert.Fail("Cidade com numero");
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ValidarCidade_CaracterEspecial()
        {
            string cidade = "São Gonçalo!!!!";
            var Cidade = new Endereco(cidade, Uf.AC);
            Assert.Fail("Cidade com caracter especial");
        }

        #endregion

        #region Testes Uf
        #endregion


    }

}

