using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Exceptions
{
   public class VagaNaoEncontradaException : Exception
    {
        public VagaNaoEncontradaException() : base("Vaga não cadastrada"){ }

        public VagaNaoEncontradaException(string msg) : base(msg) { }
    }
}
