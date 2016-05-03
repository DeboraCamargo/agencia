using MrCasting.Domain.Enuns;
using MrCasting.Domain.ValueObject;
using MrCasting.Helpers;
using System;

namespace MrCasting.Domain.Entities
{
    public class Endereco : EntityBase
    {
        #region Construtores

        protected Endereco() { }

        public Endereco(string cidade, Uf uf)
        {
            this.Cidade = cidade;
            this.Uf = uf;
        }
        #endregion

        #region Propriedades

        public const int LogradouroMaxLength = 80;
        private string _logradouro;

        public virtual string Logradouro
        {
            get { return _logradouro; }
            set
            {
                _logradouro = value;
                ValidarLogradouro();

            }
        }


        public const int ComplementoMaxLength = 100;
        private string _complemento;

        public virtual string Complemento
        {
            get { return _complemento; }
            set
            {
                _complemento = value;
                ValidarComplemento();
            }
        }


        public const int NumeroMaxLength = 20;
        private string _numero;

        public virtual string Numero
        {
            get { return _numero; }
            set
            {
                _numero = value;
                ValidarNumero();
            }
        }


        public const int BairroMaxLength = 150;
        private string _bairro;

        public virtual string Bairro
        {
            get { return _bairro; }
            set
            {
                _bairro = value;
                ValidarBairro();
            }
        }

        public const int CidadeMaxLength = 80;
        private string _cidade;

        public virtual string Cidade
        {
            get { return _cidade; }
            set
            {
                _cidade = value;
                ValidarCidade();
            }
        }


        private Uf _uf;

        public virtual Uf Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }


        public Cep Cep { get; set; }


        public virtual Int64? CepValue
        {
            get
            {
                if (Cep == null)
                    return null;
                return Cep.CepCod;
            }
            set
            {
                if (value.HasValue)
                    Cep = new Cep(value.Value);
                else
                    Cep = null;
            }
        }

        #endregion

        #region Regras de negocio

        private void ValidarComplemento()
        {
            string complemento = Complemento; ;
            if (string.IsNullOrEmpty(complemento))
                return;
            Guard.StringLength(complemento, ComplementoMaxLength, "Tamanho maximo excedido");
        }

        private void ValidarLogradouro()
        {
            string logradouro = Logradouro;
            if (string.IsNullOrEmpty(logradouro))
                return;
            Guard.StringLength(logradouro, LogradouroMaxLength, "Tamanho maximo excedido");
        }

        private void ValidarNumero()
        {
            string numero = Numero;
            if (string.IsNullOrEmpty(numero))
                return;
            Guard.StringLength(numero, NumeroMaxLength, "Tamanho maximo excedido");
        }

        private void ValidarBairro()
        {
            string bairro = Bairro;
            if (string.IsNullOrEmpty(bairro))
                return;
            Guard.StringLength(bairro, BairroMaxLength, "Tamanho maximo excedido");
        }

        private void ValidarCidade()
        {
            string cidade = Cidade;
            Guard.ForNullOrEmpty(cidade, "Não pode ser nula ou vazia");
            Guard.ForSpecialCharAndNumbers(cidade, "não pode conter numeros ou caracteres especiais");
            Guard.StringLength(cidade, CidadeMaxLength, "Tamanho maximo excedido");
        }

        #endregion

        public override string ToString()
        {
            return Logradouro + ", " + Numero + " - " + Complemento + " <br /> " + Bairro + " - " + Cidade + "/" + Uf;
        }
    }
}