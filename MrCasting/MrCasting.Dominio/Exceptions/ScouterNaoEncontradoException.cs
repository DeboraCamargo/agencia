using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Domain.Exceptions
{
    public class ScouterNaoEncontradoException : Exception
    {
        public ScouterNaoEncontradoException() : base("Scouter não cadastrado") { }

        public ScouterNaoEncontradoException(string msg) : base(msg) { }

    }

}
