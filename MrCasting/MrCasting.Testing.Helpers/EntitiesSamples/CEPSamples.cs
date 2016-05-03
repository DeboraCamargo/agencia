using MrCasting.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class CEPSamples
    {
        public const string CEP_SAMPLES = "03014-000";

        public static Cep CriarCEP()
        {
            return new Cep(CEP_SAMPLES);
        }

    }
}
