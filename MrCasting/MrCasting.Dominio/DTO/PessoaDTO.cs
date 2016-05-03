using MrCasting.Domain.Enuns;
using System;

namespace MrCasting.Domain.DTO
{
    public class PessoaDTO
    {

        #region Propriedades

        public int IdCandidato { get; set; }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public EnderecoDTO Endereco { get; set; }

        public ContatoDTO Contato { get; set; }

        public string Cpf { get; set; }

        //public string Login { get; set; }

        //public string Senha { get; set; }

        //public string SenhaConfirmacao { get; set; }

        //public Guid TokenAlteracaoDeSenha { get; set; }

        public Genero Sexo { get; set; }

        public string FotoPerfil { get; set; }


        #endregion


    }
}
