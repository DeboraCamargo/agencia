using System;

namespace MrCasting.Domain.Exceptions
{
    public class CandidatoNaoEncontradoException : Exception
    {
        public CandidatoNaoEncontradoException() : base("Candidato não cadastrado"){ }

        public CandidatoNaoEncontradoException(string msg) : base(msg) { }
    }
}
