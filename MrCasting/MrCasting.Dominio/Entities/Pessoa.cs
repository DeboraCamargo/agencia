using MrCasting.Domain.Enuns;
using MrCasting.Domain.ValueObject;
using MrCasting.Helpers;
using System;
using System.Linq;

namespace MrCasting.Domain.Entities
{

    public class Pessoa : EntityBase
    {
        #region Construtores

        public Pessoa() { }


        public Pessoa(string nome, string sobrenome,DateTime dataNascimento, Cpf cpf,Genero sexo,Contato contato)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            SetCpf(cpf);
            this.Sexo = sexo;
            this.SobreNome = sobrenome;
            ValidarDataNascimentoPessoa();
            ValidarNomePessoa();
            ValidarSobrenomePessoa();
            this.Contato = contato;
           
        }
        #endregion

        #region Propriedades

        public virtual Endereco Endereco { get;  set; }
        public virtual Contato Contato { get;  set; }
        public Cpf Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Genero Sexo { get; private set; }


        public const int NomeMaxLenght = 60;
        public const int NomeMinLenght = 2;
        public string Nome { get; private set; }

        public const int SobrenomeMaxLenght = 120;
        public string SobreNome { get; private set; }

        public byte[] FotoPerfil { get; set; }

        //public Guid TokenAlteracaoDeSenha { get; private set; }
        //public const int LoginMinValue = 6;
        //public const int LoginMaxValue = 30;
        //public string Login { get;  set; }

        //public const int SenhaMinValue = 6;
        //public const int SenhaMaxValue = 30;
        //public byte[] Senha { get;  set; }

        #endregion

        #region Regras de negocio

        //public Guid TokenAlteracaoDeSenha { get; private set; }
        //public const int LoginMinValue = 6;
        //public const int LoginMaxValue = 30;
        //public string Login { get;  set; }

        //public const int SenhaMinValue = 6;
        //public const int SenhaMaxValue = 30;
        //public byte[] Senha { get;  set; }


        //private void SetSenha(string senha, string senhaConfirmacao)
        //{
        //    Guard.ForNullOrEmptyDefaultMessage(senha, "Senha");
        //    Guard.ForNullOrEmptyDefaultMessage(senhaConfirmacao, "Confirmação de Senha");
        //    Guard.StringLength("Senha", senha, SenhaMinValue, SenhaMaxValue);
        //    Guard.AreEqual(senha, senhaConfirmacao, "As senhas não conferem!");

        //    Senha = CriptografiaHelper.CriptografarSenha(senha);
        //}

        //public void AlterarSenha(string senhaAtual, string novaSenha, string confirmacaoDeSenha)
        //{
        //    ValidarSenha(senhaAtual);
        //    SetSenha(novaSenha, confirmacaoDeSenha);
        //}

        //public void ValidarSenha(string senha)
        //{
        //    Guard.ForNullOrEmptyDefaultMessage(senha, "Senha");
        //    var senhaCriptografada = CriptografiaHelper.CriptografarSenha(senha);
        //    if (!Senha.SequenceEqual(senhaCriptografada))
        //        throw new Exception("Senha inválida!");
        //}

        //public Guid GerarNovoTokenAlterarSenha()
        //{
        //    TokenAlteracaoDeSenha = Guid.NewGuid();
        //    return TokenAlteracaoDeSenha;
        //}

        //public void AlterarSenha(Guid token, string novaSenha, string confirmacaoDeSenha)
        //{
        //    if (!TokenAlteracaoDeSenha.Equals(token))
        //        throw new Exception("token para alteração de senha inválido!");
        //    SetSenha(novaSenha, confirmacaoDeSenha);
        //    GerarNovoTokenAlterarSenha();
        //}

        private void SetCpf(Cpf cpf)
        {
            if (cpf == null)
                throw new Exception("Cpf Obrigatório");
            Cpf = cpf;
        }

        private void ValidarNomePessoa()
        {
            string nome = Nome;

            Guard.ForNull(nome, "Nome não pode ser nulo");
            Guard.ForSpecialCharAndNumbers(nome, "Nome não pode conter Caracteres especiais ou numeros");
            Guard.StringLength(nome, NomeMinLenght, NomeMaxLenght, "Nome fora dos limites de tamanho permitidos");
        }

        private void ValidarSobrenomePessoa()
        {
            string sobrenome = SobreNome;
            Guard.ForNull(sobrenome, "Sobrenome não pode ser nulo, ou conter espaços");
            Guard.ForSpecialCharAndNumbers(sobrenome, "Nome não pode conter Caracteres especiais ou numeros");
            Guard.StringLength(sobrenome, SobrenomeMaxLenght, "Sobrenome fora dos limites de tamanho permitidos");
        }
        private void ValidarDataNascimentoPessoa()
        {
            DateTime nascimento = DataNascimento;

            if(nascimento == DateTime.MinValue)
            {
                throw new Exception("Data de nascimento não pode ser nula");
            }
            if(nascimento.Equals(new DateTime()))
            {
                throw new Exception("Data de nascimento não pode ser vazia");
            }
            if (nascimento.Year <= new DateTime(1880,1,1).Year)
            {
                throw new Exception("Data de nascimento não pode ser antes de 1880");
            }
            if (nascimento.Date>DateTime.Today)
            {
                throw new Exception("Data de nascimento não pode depois do dia atual");

            }
            
        }
        #endregion
    }
}

