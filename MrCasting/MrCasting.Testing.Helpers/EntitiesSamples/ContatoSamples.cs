using System;
using MrCasting.Domain.Entities;
using MrCasting.Domain.ValueObject;
using MrCasting.Domain.DTO;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class ContatoSamples
    {

        public static Contato CriarContatoValido()
        {
            return new Contato(EmailSamples.CriarEmailValido(), TelefoneSamples.CriarTelefoneValido());
        }

        public static ContatoDTO CriarContatoDTOValido()
        {
            return new ContatoDTO()
            {
                //DDD = TelefoneSamples.DDD_VALIDO,
                Telefone = TelefoneSamples.DDD_VALIDO+TelefoneSamples.NUMERO_VALIDO,
                Email = EmailSamples.EMAIL_VALIDO
            };
        }


    }
}