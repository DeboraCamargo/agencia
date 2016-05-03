using System;

namespace MrCasting.Domain.Exceptions
{
    public class UsuarioNaoCadastradoException : Exception
    {
        public UsuarioNaoCadastradoException() : base("Usuario não cadastrado"){}

        public UsuarioNaoCadastradoException(string msg) : base(msg) { }
    }
}
