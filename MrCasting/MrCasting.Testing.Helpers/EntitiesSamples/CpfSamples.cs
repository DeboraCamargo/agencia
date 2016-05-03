using System;
using MrCasting.Domain.ValueObject;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class CpfSamples
    {
        public const string CPF_VALIDO = "33550028873";

        public static Cpf CriarCPFValido()
        {
            return new Cpf(CPF_VALIDO);
        }
    }
}