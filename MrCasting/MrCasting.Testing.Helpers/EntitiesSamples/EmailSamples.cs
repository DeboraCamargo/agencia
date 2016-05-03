using MrCasting.Domain.ValueObject;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class EmailSamples
    {
        public const string EMAIL_VALIDO = "me.imagine.debby@gmail.com";

        public static Email CriarEmailValido()
        {
            return new Email(EMAIL_VALIDO);
        }

    }
}