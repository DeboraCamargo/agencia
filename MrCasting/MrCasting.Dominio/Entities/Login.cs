using MrCasting.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Entities
{
  public class Login : EntityBase
    {

        public Login() { }

        public Guid TokenAlteracaoDeSenha { get; private set; }
        public const int LoginMinValue = 6;
        public const int LoginMaxValue = 30;
        public string Usuario { get; set; }

        public const int SenhaMinValue = 6;
        public const int SenhaMaxValue = 30;
        public byte[] Senha { get; set; }
       

        private void SetSenha(string senha, string senhaConfirmacao)
        {
            Guard.ForNullOrEmptyDefaultMessage(senha, "Senha");
            Guard.ForNullOrEmptyDefaultMessage(senhaConfirmacao, "Confirmação de Senha");
            Guard.StringLength("Senha", senha, SenhaMinValue, SenhaMaxValue);
            Guard.AreEqual(senha, senhaConfirmacao, "As senhas não conferem!");

            Senha = CriptografiaHelper.CriptografarSenha(senha);
        }

        public void AlterarSenha(string senhaAtual, string novaSenha, string confirmacaoDeSenha)
        {
            ValidarSenha(senhaAtual);
            SetSenha(novaSenha, confirmacaoDeSenha);
        }

        public void ValidarSenha(string senha)
        {
            Guard.ForNullOrEmptyDefaultMessage(senha, "Senha");
            var senhaCriptografada = CriptografiaHelper.CriptografarSenha(senha);
            if (!Senha.SequenceEqual(senhaCriptografada))
                throw new Exception("Senha inválida!");
        }

        public Guid GerarNovoTokenAlterarSenha()
        {
            TokenAlteracaoDeSenha = Guid.NewGuid();
            return TokenAlteracaoDeSenha;
        }

        public void AlterarSenha(Guid token, string novaSenha, string confirmacaoDeSenha)
        {
            if (!TokenAlteracaoDeSenha.Equals(token))
                throw new Exception("token para alteração de senha inválido!");
            SetSenha(novaSenha, confirmacaoDeSenha);
            GerarNovoTokenAlterarSenha();
        }



    }
}
