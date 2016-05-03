using MrCasting.Domain.ValueObject;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class TelefoneSamples
    {
        public const string DDD_VALIDO = "011";
        public const string NUMERO_VALIDO = "985424740";

        public static Telefone CriarTelefoneValido()
        {
            return new Telefone(DDD_VALIDO, NUMERO_VALIDO);
        }
    }
}