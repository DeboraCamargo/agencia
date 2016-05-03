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
    public class CaracteristicasFisicasTest
    {

        public const string COR_OLHOS_VALIDA = "Castanho";
        public const string COR_PELE_VALIDA = "Preto";
        public const decimal SAPATO_VALIDO = 36m;
        public const decimal MANEQUIM_VALIDO = 46m;

        #region Testes string CorOlhos
        //public const int CorDosOlhosMaxLenght = 20;
        //public const int CorDosolhosMinLenght = 2;
        //public string CorOlhos { get; private set; }

        [TestMethod]
        public void CRFisica_CorOlhos_Valido()
        {
            string corOlhos = "Azul";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorOlhos = corOlhos;

            Assert.AreEqual(corOlhos, CaracteristicaFisica.CorOlhos);
        }


        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorOlhos_Nulo()
        {
            string corOlhos = null;
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorOlhos = corOlhos;
            Assert.Fail("Cor dos olhos não pode ser nula");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorOlhos_Empty()
        {
            var corOlhos = "";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorOlhos = corOlhos;
            Assert.Fail("Cor dos olhos não pode ser vazia");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorOlhos_Com_Numero()
        {
            var corOlhos = "Azul5";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorOlhos = corOlhos;

            Assert.Fail("Cor dos olhos não pode conter numero");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorOlhos_Com_caracter_Especial()
        {
            var corOlhos = "Azul!";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorOlhos = corOlhos;

            Assert.Fail("Cor dos olhos não pode conter caracteres especiais");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorOlhos_MaxLengh()
        {
            var corOlhos = "AzulAzulAzulAzulAzulAzulAzulAzulAzulAzulAzulAzulAzulAzulAzul";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorOlhos = corOlhos;

            Assert.Fail("Cor dos olhos com tamanho superior ao esperado");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorOlhos_MinLengh()
        {
            var corOlhos = "A";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorOlhos = corOlhos;

            Assert.Fail("Cor dos olhos com tamanho menor que o esperado");
        }

        #endregion

        #region Testes string CorPele
        //public const int CorDaPeleMaxLenght = 20;
        //public const int CorDaPeleMinLenght = 2;
        //public string CorPele { get; private set; }

        [TestMethod]
        public void CRFisica_CorPele_Valido()
        {
            var corPele = "Branca";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorPele = corPele;

            Assert.AreEqual(corPele, CaracteristicaFisica.CorPele);

        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorPele_Nulo()
        {
            string corPele = null;
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorPele = corPele;
            Assert.Fail("Cor da pele não pode ser nula");
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorPele_Empty()
        {
            var corPele = "";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorPele = corPele;

            Assert.Fail("Cor da pele não pode  ser vazia");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorPele_Com_Numero()
        {
            var corPele = "Azul5";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorPele = corPele;

            Assert.Fail("Cor da pele não pode conter numeros");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorPele_Com_caracter_Especial()
        {
            var corPele = "Azul!";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorPele = corPele;
            Assert.Fail("Cor da pele não pode conter caracteres especiais");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorPele_MaxLengh()
        {
            var corPele = "Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorPele = corPele;
            Assert.Fail("Cor da pele tamanho maximo");
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_CorPele_MinLengh()
        {
            var corPele = "A";
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.CorPele = corPele;
            Assert.Fail("Cor da pele tamanho minimo");

        }
        #endregion

        #region Testes Manequim
        //public int Manequim { get; private set; }

        [TestMethod]
        public void CRFisica_Manequim_Valido()
        {
            var manequim = 36;
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Manequim = manequim;
            Assert.AreEqual(manequim, CaracteristicaFisica.Manequim);

        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Manequim_Numero_Maximo()
        {
            var manequim = 200;
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Manequim = manequim;
            Assert.Fail("Manequim  numero tamanho maximo");

        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Manequim_Numero_Minimo()
        {
            var manequim = 0;
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Manequim = manequim;
            Assert.Fail("Manequim  numero tamanho minimo - não pode ser 0");

        }


        #endregion

        #region Testes Sapato
        //public int Sapato { get; private set; }

        [TestMethod]
        public void CRFisica_Sapato_Valido()
        {
            var sapato = 36;
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Sapato = sapato;
            Assert.AreEqual(sapato, CaracteristicaFisica.Sapato);


        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Sapato_Numero_Maximo()
        {
            var sapato = 200;
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Sapato = sapato;
            Assert.Fail("Sapato tamanho maximo");

        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Sapato_Numero_Minimo()
        {
            var sapato = 0;
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Sapato = sapato;
            Assert.Fail("Sapato tamanho minimo");

        }


        #endregion

        #region Testes Altura
        //public decimal Altura { get; private set; }

        [TestMethod]
        public void CRFisica_Altura_Valido()
        {
            var altura = 1.64m;
            CaracteristicasFisicas CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Altura = altura;

        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Altura_Com_Zero()
        {
            var altura = 0;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Altura = altura;

        }


        #endregion

        #region Testes Cintura
        //public decimal Cintura { get; private set; }

        [TestMethod]
        public void CRFisica_Cintura_Valida()
        {
            var cintura = 0.60m;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Cintura = cintura;

        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Cintura_Com_Zero()
        {
            var cintura = 0;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Cintura = cintura;

        }

        #endregion

        #region Testes Busto
        //public decimal Busto { get; private set; }

        [TestMethod]
        public void CRFisica_Busto_Valido()
        {
            var busto = 0.60m;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Busto = busto;

        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Busto_Com_Zero()
        {
            var busto = 0;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Busto = busto;

        }

        #endregion

        #region Testes Quadril
        //public decimal Quadril { get; private set; }
        [TestMethod]
        public void CRFisica_Quadril_Valido()
        {
            var quadril = 0.60m;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Busto = quadril;

        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Quadril_Com_Zero()
        {
            var quadril = 0;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Quadril = quadril;

        }


        #endregion

        #region Testes ComprimentoCabelo

        //public const int ComprimentoCabeloMaxSize = 30;
        //public const int ComprimentoCabeloMinSize = 2;
        //public string ComprimentoCabelo { get; private set; }

        [TestMethod]
        public void CRFisica_ComprimentoCabelo_Valido()
        {
            var comprimentoCabelo = "Grande";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.ComprimentoCabelo = comprimentoCabelo;

        }
        [TestMethod]
        public void CRFisica_ComprimentoCabelo_Nulo()
        {
            string comprimentoCabelo = null;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.ComprimentoCabelo = comprimentoCabelo;
        }

        [TestMethod]
        public void CRFisica_ComprimentoCabelo_Empty()
        {
            var comprimentoCabelo = "";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.ComprimentoCabelo = comprimentoCabelo;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_ComprimentoCabelo_Com_Numero()
        {
            var comprimentoCabelo = "Curto9";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.ComprimentoCabelo = comprimentoCabelo;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_ComprimentoCabelo_Com_caracter_Especial()
        {
            var comprimentoCabelo = "Ombro!";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.ComprimentoCabelo = comprimentoCabelo;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_ComprimentoCabelo_MaxLengh()
        {
            var comprimentoCabelo = "Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.ComprimentoCabelo = comprimentoCabelo;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_ComprimentoCabelo_MinLengh()
        {
            var comprimentoCabelo = "A";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.ComprimentoCabelo = comprimentoCabelo;
        }



        #endregion

        #region Testes TipoCabelo
        //public const int TipoCabeloMaxSize = 30;
        //public const int TipoCabeloMinSize = 2;
        //public string TipoCabelo { get; private set; }



        [TestMethod]
        public void CRFisica_TipoCabelo_Valido()
        {
            var tipoCabelo = "Crespo";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoCabelo = tipoCabelo;

        }
        [TestMethod]
        public void CRFisica_TipoCabelo_Nulo()
        {
            string tipoCabelo = null;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoCabelo = tipoCabelo;
        }

        [TestMethod]
        public void CRFisica_TipoCabelo_Empty()
        {
            var tipoCabelo = "";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoCabelo = tipoCabelo;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_TipoCabelo_Com_Numero()
        {
            var tipoCabelo = "Curto9";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoCabelo = tipoCabelo;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_TipoCabelo_Com_caracter_Especial()
        {
            var tipoCabelo = "Ombro!";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoCabelo = tipoCabelo;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_TipoCabelo_MaxLengh()
        {
            var tipoCabelo = "Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5Azul5";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoCabelo = tipoCabelo;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_TipoCabelo_MinLengh()
        {
            var tipoCabelo = "A";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoCabelo = tipoCabelo;
        }




        #endregion

        #region Testes Etnia
        //public const int EtniaMaxSize = 30;
        //public const int EtniaMinSize = 2;
        //public string Etnia { get; private set; }


        [TestMethod]
        public void CRFisica_Etnia_Valido()
        {
            var Etnia = "Caucasiano";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Etnia = Etnia;

        }
        [TestMethod]
        public void CRFisica_Etnia_Nulo()
        {
            string Etnia = null;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Etnia = Etnia;
        }

        [TestMethod]
        public void CRFisica_Etnia_Empty()
        {
            var Etnia = "";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Etnia = Etnia;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Etnia_Com_Numero()
        {
            var Etnia = "Afro0";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Etnia = Etnia;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Etnia_Com_caracter_Especial()
        {
            var Etnia = "Turco!";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Etnia = Etnia;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Etnia_MaxLengh()
        {
            var Etnia = "LatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatina";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Etnia = Etnia;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Etnia_MinLengh()
        {
            var Etnia = "A";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Etnia = Etnia;
        }




        #endregion

        #region Testes Descendencia

        //public const int DescendenciaMaxSize = 60;
        //public const int DescendenciaMinSize = 2;
        //public string Descendencia { get; private set; }

        [TestMethod]
        public void CRFisica_Descendencia_Valido()
        {
            var Descendencia = "Caucasiano";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Descendencia = Descendencia;

        }
        [TestMethod]
        public void CRFisica_Descendencia_Nulo()
        {
            string Descendencia = null;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Descendencia = Descendencia;
        }

        [TestMethod]
        public void CRFisica_Descendencia_Empty()
        {
            var Descendencia = "";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Descendencia = Descendencia;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Descendencia_Com_Numero()
        {
            var Descendencia = "Afro0";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Descendencia = Descendencia;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Descendencia_Com_caracter_Especial()
        {
            var Descendencia = "Turco!";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Descendencia = Descendencia;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Descendencia_MaxLengh()
        {
            var Descendencia = "LatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatina";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Descendencia = Descendencia;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Descendencia_MinLengh()
        {
            var Descendencia = "A";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Descendencia = Descendencia;
        }




        #endregion

        #region Testes Peso
        //public decimal Peso { get; private set; }

        [TestMethod]
        public void CRFisica_Peso_Valida()
        {
            var Peso = 20.60m;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Peso = Peso;

        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Peso_Com_Zero()
        {
            var Peso = 0;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Peso = Peso;

        }


        #endregion

        #region Testes TipoFisico
        //public const int TipoFisicoMaxSize = 30;
        //public const int TipoFisicoMinSize = 2;
        //public string TipoFisico { get; private set; }

        [TestMethod]
        public void CRFisica_TipoFisico_Valido()
        {
            var TipoFisico = "Caucasiano";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoFisico = TipoFisico;

        }
        [TestMethod]
        public void CRFisica_TipoFisico_Nulo()
        {
            string TipoFisico = null;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoFisico = TipoFisico;
        }

        [TestMethod]
        public void CRFisica_TipoFisico_Empty()
        {
            var TipoFisico = "";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoFisico = TipoFisico;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_TipoFisico_Com_Numero()
        {
            var TipoFisico = "Afro0";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoFisico = TipoFisico;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_TipoFisico_Com_caracter_Especial()
        {
            var TipoFisico = "Turco!";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoFisico = TipoFisico;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_TipoFisico_MaxLengh()
        {
            var TipoFisico = "LatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatina";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoFisico = TipoFisico;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_TipoFisico_MinLengh()
        {
            var TipoFisico = "A";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.TipoFisico = TipoFisico;
        }




        #endregion

        #region Testes Terno
        //public const int TernoMaxSize = 60;
        //public const int TernoMinSize = 4;
        //public string Terno { get; private set; }

        [TestMethod]
        public void CRFisica_Terno_Valido()
        {
            var Terno = "Caucasiano";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Terno = Terno;

        }
        [TestMethod]
        public void CRFisica_Terno_Nulo()
        {
            string Terno = null;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Terno = Terno;
        }

        [TestMethod]
        public void CRFisica_Terno_Empty()
        {
            var Terno = "";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Terno = Terno;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Terno_Com_Numero()
        {
            var Terno = "Afro0";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Terno = Terno;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Terno_Com_caracter_Especial()
        {
            var Terno = "Turco!";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Terno = Terno;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Terno_MaxLengh()
        {
            var Terno = "LatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatina";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Terno = Terno;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Terno_MinLengh()
        {
            var Terno = "A";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Terno = Terno;
        }



        #endregion

        #region Testes Camisa
        //public const int CamisaMaxSize = 60;
        //public const int CamisaMinsize = 2;
        //public string Camisa { get; private set; }

        [TestMethod]
        public void CRFisica_Camisa_Valido()
        {
            var Camisa = "camisa";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Camisa = Camisa;

        }
        [TestMethod]
        public void CRFisica_Camisa_Nulo()
        {
            string Camisa = null;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Camisa = Camisa;
        }

        [TestMethod]
        public void CRFisica_Camisa_Empty()
        {
            var Camisa = "";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Camisa = Camisa;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Camisa_Com_Numero()
        {
            var Camisa = "Afro0";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Camisa = Camisa;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Camisa_Com_caracter_Especial()
        {
            var Camisa = "Turco!";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Camisa = Camisa;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Camisa_MaxLengh()
        {
            var Camisa = "LatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatinaLatina";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Camisa = Camisa;
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Camisa_MinLengh()
        {
            var Camisa = "A";
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Camisa = Camisa;
        }




        #endregion

        #region Testes Torax

        //public decimal Torax { get; private set; }

        [TestMethod]
        public void CRFisica_Torax_Valida()
        {
            var Torax = 0.60m;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Torax = Torax;

        }

        [TestMethod]
        public void CRFisica_Torax_Nulo()
        {
            decimal? Torax = null;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Torax = Torax;

        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void CRFisica_Torax_Com_Zero()
        {
            var Torax = 0;
            var CaracteristicaFisica = new CaracteristicasFisicas();
            CaracteristicaFisica.Torax = Torax;

        }

        #endregion

    }
}







