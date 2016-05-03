using MrCasting.Helpers;
using System;

namespace MrCasting.Domain.Entities
{
    public class CaracteristicasFisicas : EntityBase
    {

        #region Construtores
        public CaracteristicasFisicas() { }

        #endregion

        #region Propriedades
        //public int IdCandidato { get; set; }

        //public virtual Candidato Candidato { get; set; }

        public const int CorDosOlhosMaxLenght = 20;
        public const int CorDosolhosMinLenght = 2;
        private string _corOlhos;
        public string CorOlhos
        {
            get { return _corOlhos; }
            set
            {
                _corOlhos = value;
                ValidarCorDosOlhos();
            }
        }


        public const int CorDaPeleMaxLenght = 20;
        public const int CorDaPeleMinLenght = 2;
        private string _corPele;
        public string CorPele
        {
            get { return _corPele; }
            set
            {
                _corPele = value;
                ValidarCorDaPele();
            }
        }


        private decimal? _manequim;
        public decimal? Manequim
        {
            get { return _manequim; }
            set
            {
                _manequim = value;
                ValidarManequim();
            }
        }

        private decimal? _altura;
        public decimal? Altura
        {
            get { return _altura; }
            set
            {
                _altura = value;
                ValidarAltura();
            }
        }

        private decimal? _cintura;
        public decimal? Cintura
        {
            get { return _cintura; }
            set
            {
                _cintura = value;
                ValidarCintura();
            }
        }

        private decimal? _busto;
        public decimal? Busto
        {
            get { return _busto; }
            set
            {
                _busto = value;
                ValidarBusto();
            }
        }

        private decimal? _quadril;
        public decimal? Quadril
        {
            get { return _quadril; }
            set
            {
                _quadril = value;
                ValidarQuadril();

            }
        }

        private decimal? _sapato;
        public decimal? Sapato
        {
            get { return _sapato; }
            set
            {
                _sapato = value;
                ValidarSapato();
            }
        }

        public const int ComprimentoCabeloMaxSize = 30;
        public const int ComprimentoCabeloMinSize = 2;
        private string _comprimentoCabelo;
        public string ComprimentoCabelo
        {
            get { return _comprimentoCabelo; }
            set
            {
                _comprimentoCabelo = value;
                ValidarComprimentoCabelo();
            }
        }

        public const int TipoCabeloMaxSize = 30;
        public const int TipoCabeloMinSize = 2;
        private string _tipoCabelo;
        public string TipoCabelo
        {
            get { return _tipoCabelo; }
            set
            {
                _tipoCabelo = value;
                ValidarTipoCabelo();
            }
        }

        public const int EtniaMaxSize = 30;
        public const int EtniaMinSize = 2;
        private string _etnia;
        public string Etnia
        {
            get { return _etnia; }
            set
            {
                _etnia = value;
                ValidarEtnia();
            }
        }

        public const int DescendenciaMaxSize = 60;
        public const int DescendenciaMinSize = 2;
        private string _descendencia;
        public string Descendencia
        {
            get { return _descendencia; }
            set
            {
                _descendencia = value;
                ValidarDescendencia();
            }
        }

        private decimal? _peso;
        public decimal? Peso
        {
            get { return _peso; }
            set
            {
                _peso = value;
                ValidarPeso();
            }
        }

        public const int TipoFisicoMaxSize = 30;
        public const int TipoFisicoMinSize = 2;
        private string _tipoFisico;
        public string TipoFisico
        {
            get { return _tipoFisico; }
            set
            {
                _tipoFisico = value;
                ValidarTipoFisico();
            }
        }


        public const int TernoMaxSize = 60;
        public const int TernoMinSize = 4;
        private string _terno;
        public string Terno
        {
            get { return _terno; }
            set
            {
                _terno = value;
                ValidarTerno();
            }
        }

        public const int CamisaMaxSize = 60;
        public const int CamisaMinsize = 2;
        private string _camisa;
        public string Camisa
        {
            get { return _camisa; }
            set
            {
                _camisa = value;

                ValidarCamisa();

            }
        }

        private decimal? _torax;
        public decimal? Torax
        {
            get { return _torax; }
            set
            {
                _torax = value;
                ValidarTorax();
            }
        }



        #endregion

        #region Regras de Negocio

        public void ValidarCorDosOlhos()
        {
            string corOlhos = CorOlhos;

            Guard.ForNullOrEmpty(corOlhos, "Cor dos olhos não pode ser nula ou vazia");
            Guard.ForSpecialCharAndNumbers(corOlhos, "Cor dos olhos não pode ter caracter especial ou numeros");
            Guard.StringLength(corOlhos, CorDosolhosMinLenght, CorDosOlhosMaxLenght, "Tamanho da cor dos olhos fora do estipulado");
        }
        public void ValidarCorDaPele()
        {
            string corDaPele = CorPele;

            Guard.ForNullOrEmpty(corDaPele, "Cor da pele não pode ser nula ou vazia");
            Guard.ForSpecialCharAndNumbers(corDaPele, "Cor da pele não pode conter caracter especial ou numeros");
            Guard.StringLength(corDaPele, CorDaPeleMinLenght, CorDaPeleMaxLenght, "Tamanho da cor da pele fora do estipulado");
        }
        public void ValidarManequim()
        {

            if (Manequim.HasValue)
            {
                decimal? manequim = Manequim;


                if (manequim <= 0)
                {
                    throw new Exception("Campo manequim não pode ser 0");
                }

                if (manequim >= 200)

                {
                    throw new Exception("Campo manequim não pode ser 200 ou mais");
                }
            }
        }
        public void ValidarAltura()
        {
            decimal? altura = Altura;

            if (altura <= 0.0m)
            {
                throw new Exception("Campo altura não pode ser 0");
            }

        }

        public void ValidarCintura()
        {
            decimal? cintura = Cintura;

            if (cintura <= 0.0m)
            {
                throw new Exception("Campo cintura não pode ser 0");
            }
        }
        public void ValidarBusto()
        {
            if (Busto.HasValue)
            {
                decimal? busto = Busto.Value;

                if (busto <= 0.0m)
                {
                    throw new Exception("Campo busto não pode ser 0");
                }
            }
        }
        public void ValidarQuadril()
        {
            if (Quadril.HasValue)
            {
                decimal quadril = Quadril.Value;

                if (quadril <= 0)
                {
                    throw new Exception("Campo quadril não pode ser 0");
                }
            }
        }
        public void ValidarSapato()
        {

            if (Sapato.HasValue)
            {

                decimal sapato = Sapato.Value;

                if (sapato <= 0)
                {
                    throw new Exception("Campo sapato não pode ser 0");
                }

                if (sapato >= 200)

                {
                    throw new Exception("Campo sapato não pode ser 200 ou mais");
                }
            }
        }
        public void ValidarComprimentoCabelo()
        {
            string comprimentoCabelo = ComprimentoCabelo;

            if (string.IsNullOrEmpty(comprimentoCabelo))
                return;

            Guard.ForSpecialCharAndNumbers(comprimentoCabelo, "Campo comprimento do cabelo não pode conter numeros ou caracteres especiais");
            Guard.StringLength(comprimentoCabelo, ComprimentoCabeloMinSize, ComprimentoCabeloMaxSize, "Campo comprimento cabelo com tamanho fora do estipulado");
        }
        public void ValidarTipoCabelo()
        {
            string tipoCabelo = TipoCabelo;

            if (string.IsNullOrEmpty(tipoCabelo))
                return;

            Guard.ForSpecialCharAndNumbers(tipoCabelo, "Tipo de cabelo não pode conter numeros ou caracteres especiais");
            Guard.StringLength(tipoCabelo, TipoCabeloMinSize, TipoCabeloMaxSize, "campo tipo cabelo fora do tamanho adequado");
        }
        public void ValidarEtnia()
        {
            string etnia = Etnia;

            if (string.IsNullOrEmpty(etnia))
                return;

            Guard.ForSpecialCharAndNumbers(etnia, "Etnia não pode conter numeros ou caracteres especiais");
            Guard.StringLength(etnia, EtniaMinSize, EtniaMaxSize, "campo etnia fora do tamanho adequado");
        }
        public void ValidarDescendencia()
        {
            string desc = Descendencia;

            if (string.IsNullOrEmpty(desc))
                return;

            Guard.ForSpecialCharAndNumbers(desc, "descendencia não pode conter numeros ou caracteres especiais");
            Guard.StringLength(desc, DescendenciaMinSize, DescendenciaMaxSize, "campo descendencia fora do tamanho adequado");
        }
        public void ValidarPeso()
        {
            decimal? peso = Peso;
            if (peso <= 0)
            {
                throw new Exception("Campo peso não pode ser 0");
            }


        }
        public void ValidarTipoFisico()
        {
            string tipoFisico = TipoFisico;

            if (string.IsNullOrEmpty(tipoFisico))
                return;

            Guard.ForSpecialCharAndNumbers(tipoFisico, "tipo Fisico não pode conter numeros ou caracteres especiais");
            Guard.StringLength(tipoFisico, TipoFisicoMinSize, TipoFisicoMaxSize, "campo tipo Fisico fora do tamanho adequado");
        }
        public void ValidarTerno()
        {
            string terno = Terno;

            if (string.IsNullOrEmpty(terno))
                return;

            Guard.ForSpecialCharAndNumbers(terno, "terno não pode conter numeros ou caracteres especiais");
            Guard.StringLength(terno, TernoMinSize, TernoMaxSize, "campo terno fora do tamanho adequado");
        }
        public void ValidarTorax()
        {

            decimal? torax = Torax;
            if (torax <= 0)
            {
                throw new Exception("Campo torax não pode ser 0");
            }
        }

        public void ValidarCamisa()
        {
            string camisa = Camisa;

            if (string.IsNullOrEmpty(camisa))
                return;

            Guard.ForSpecialCharAndNumbers(camisa, "Camisa não pode conter caracter especial ou numeros");
            Guard.StringLength(camisa, CamisaMinsize, CamisaMaxSize, "Tamanho do campo camisa fora do estipulado");
        }


        #endregion


    }
}
