using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Exceptions
{
   public class PropostaNaoEncontradaException : Exception
    {
        public PropostaNaoEncontradaException() : base("Proposta não cadastrado"){ }

        public PropostaNaoEncontradaException(string msg) : base(msg) { }
    }
}
