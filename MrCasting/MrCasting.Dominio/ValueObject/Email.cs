using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MrCasting.Domain.ValueObject
{
    public class Email
    {
        public const int EnderecoMaxLength = 254;
        public string EnderecoDeEmail { get; private set; }

        protected Email()
        {}

        public Email(string endereco)
        {
            if (string.IsNullOrEmpty(endereco))
                throw new Exception("E-mail não informado");

            if (endereco.Length > EnderecoMaxLength)
                throw new Exception(string.Format("E-mail deve ter no máximo {0} caracteres",EnderecoMaxLength));

            if (IsValid(endereco) == false)
                throw new Exception("E-mail inválido");

            EnderecoDeEmail = endereco;
        }

        public static bool IsValid(string email)
        {
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            return regexEmail.IsMatch(email);
        }
    }
}
