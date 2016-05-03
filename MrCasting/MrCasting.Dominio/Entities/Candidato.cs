using MrCasting.Domain.Enuns;
using MrCasting.Domain.ValueObject;
using MrCasting.Helpers;
using System.Collections.Generic;

namespace MrCasting.Domain.Entities
{
    public class Candidato : EntityBase
    {

        #region Contrutores

        protected Candidato() { }

        public Candidato(Pessoa dadosPessoais, string nomeFantasia,Interesse interesse)
        {
            this.DadosPessoais = dadosPessoais;
            this.NomeFantasia = nomeFantasia;
            this.Interesse = interesse;
            ValidaDadosPessoas();
            ValidaNomeFantasiaCandidato();
        }

        #endregion

        #region Propriedades

        public virtual Pessoa DadosPessoais { get; set; }

        public virtual List<FotoObj> AlbumFotos { get; set; }

        public virtual List<VideoObj> AlbumVideos { get; set; }

        public IdentidadeGenero OrientacaoSexual { get; set; }

        public virtual CaracteristicasFisicas CaracteristicaFisica { get; set; }

        private string _drt;
        public string DRT
        {
            get { return _drt; }
            set
            {
                _drt = value;
                ValidarDRT();
            }
        }

        public const int NomeFantasiaMaxLenght = 60;
        public const int NomeFantasiaMinLenght = 1;
        public string NomeFantasia { get;  set; }

        public const int SobrenomeFantasiaMaxLenght = 60;
        public const int SobrenomeFantasiaMinLenght = 1;
        public string SobrenomeFantasia { get; set; }

        public const int ProfissaoMaxLenght = 60;
        public const int ProfissaoMinLenght = 2;
        private string _profissao;
        public string Profissao
        {
            get { return _profissao; }
            set
            {
                _profissao = value;
                ValidaProfissaoCandidato();
            }
        }

        public const int RealiseMaxLenght = 1000;
        public const int RealiseMinLenght = 10;
        private string _realise;
        public string Realise
        {
            get { return _realise; }
            set
            {
                _realise = value;
                ValidaRealiseCandidato();
            }
        }

        public const int NaturalidadeMaxLenght = 120;
        public const int NaturalidadeMinLenght = 2;
        private string _naturalidade;
        public string Naturalidade
        {
            get { return _naturalidade; }
            set
            {
                _naturalidade = value;
                ValidarNaturalidadeCandidato();
            }
        }

        public const int NacionalidadeMaxLenght = 120;
        public const int NacionalidadeMinLenght = 2;
        private string _nacionalidade;
        public string Nacionalidade
        {
            get { return _nacionalidade; }
            set
            {
                _nacionalidade = value;
                ValidarNacionalidadeCandidato();
            }
        }

        public virtual List<Tags> Tags { get; set; }

        public virtual List<Hobby> Hobby { get; set; }

        public virtual List<Habilidade> Habilidade { get; set; }

        public virtual Interesse Interesse { get; set; }

        #endregion

        #region Regras de Negocio

        private bool validaCandidato(string nome)
        {
            Guard.StringLength("Nome", nome, NomeFantasiaMinLenght, Guard.StringSizeType.MinLenght);
            Guard.StringLength("Nome", nome, NomeFantasiaMaxLenght, Guard.StringSizeType.MaxLenght);
            return true;
        }

        private void ValidaNomeFantasiaCandidato()
        {
            string nomeFantasia = NomeFantasia;

            Guard.StringLength(nomeFantasia, NomeFantasiaMinLenght, NomeFantasiaMaxLenght, "nome fora do tamanho adequado: Pode conter no maximo 60 caracteres e no minimo 2");
            Guard.ForNullOrEmpty(nomeFantasia, "nome não pode ser nulo ou vazio");
            Guard.ForNullOrWhiteSpace(nomeFantasia, "nome fantasia não pode conter somente espaço");
            //Guard.ForContainSpace(nomeFantasia, "nome fantasia não pode conter espaço");

        }

        //private void ValidaSobreNomeFantasiaCandidato()
        //{
        //    string sobrenome = SobrenomeFantasia;
        //    if (string.IsNullOrEmpty(sobrenome))
        //        return;

        //    Guard.StringLength(sobrenome, SobrenomeFantasiaMaxLenght, "Sobrenome fora do tamanho adequado: Pode conter no maximo 60 caracteres e no minimo 2");
        //    Guard.ForNullOrWhiteSpace(sobrenome, "Sobrenome fantasia não pode ser nulo ou conter somente espaços");
        //}

        private void ValidaProfissaoCandidato()
        {
            string profissao = Profissao;
            if (string.IsNullOrEmpty(profissao))
                return;
            Guard.StringLength(profissao, ProfissaoMinLenght, ProfissaoMaxLenght, "Profissao fora do tamanho adequado");
            Guard.ForSpecialCharAndNumbers(profissao, "profissao não pode conter caracter especial ou numero");
            Guard.ForNullOrWhiteSpace(profissao, "Sobrenome não pode ser nulo ou conter somente espaços");

        }

        private void ValidaRealiseCandidato()
        {
            string realise = Realise;
            if (string.IsNullOrEmpty(realise))
                return;
            Guard.StringLength(realise, RealiseMinLenght, RealiseMaxLenght, "Realise fora do tamanho adequado");

        }

        private void ValidarNaturalidadeCandidato()
        {
            string naturalidade = Naturalidade;
            if (string.IsNullOrEmpty(naturalidade))
                return;

            Guard.StringLength(naturalidade, NaturalidadeMinLenght, NaturalidadeMaxLenght, "Naturalidade fora do tamanho adequado");
            Guard.ForNullOrWhiteSpace(naturalidade, "Naturalidade não pode ser nulo e/ou não pode conter espaços");
            Guard.ForSpecialCharAndNumbers(naturalidade, "naturalidade não pode conter caracteres especiais ou numeros");
        }

        private void ValidarNacionalidadeCandidato()
        {
            string nacionalidade = Nacionalidade;

            if (string.IsNullOrEmpty(nacionalidade))
                return;

            Guard.ForNullOrWhiteSpace(nacionalidade, "Nacionalidade não pode ser nula ou conter somente espaços");
            Guard.StringLength(nacionalidade, NacionalidadeMinLenght, NacionalidadeMaxLenght, "Nacionalidade fora do tamanho adequado");
            Guard.ForSpecialCharAndNumbers(nacionalidade, "Nacionalidade não pode conter numeros ou caracteres especiais");

        }

        private void ValidarDRT()
        {
            string drt = DRT;
            if (string.IsNullOrEmpty(drt))
                return;
            Guard.ForSpecialCharacter(drt, "Drt não pode conter caracter especial");
        }

        private void ValidaDadosPessoas()
        {
            Guard.ForNull(DadosPessoais, "DadosPessoais não pode ser nulo");
        }

        #endregion
    }
}
