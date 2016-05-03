using MrCasting.Helpers;
using System;

namespace MrCasting.Domain.ValueObject
{
    public class Telefone
    {
        public const int NumeroMaxLength = 20;
        public string Numero { get; private set; }

        public const int DDDMaxLength = 3;
        public string DDD { get; private set; }

        protected Telefone()
        {

        }

        public Telefone(string ddd, string numero)
        {
            SetTelefone(numero);
            SetDDD(ddd);
        }


        public Telefone(string numero)
        {
            while (numero.Length > 0 && numero[0] == 0)
            {
                numero = numero.Substring(0);
            }

            if (numero.Length > 9)
            {
                string ddd = numero.Substring(0, 2);
                string telefone = numero.Substring(2);
                SetDDD(ddd);
                SetTelefone(telefone);
            }
            else
            {
                throw new Exception("Telefone no formato DDD+Telefone");
            }
        }

        private void SetTelefone(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                numero = "";
            else
                Guard.StringLength("Telefone", numero, NumeroMaxLength);
            Numero = numero;
        }

        private void SetDDD(string ddd)
        {
            if (string.IsNullOrEmpty(ddd))
                ddd = "";
            else
                Guard.StringLength("DDD", ddd, DDDMaxLength);
            DDD = ddd;
        }
        
        public string GetTelefoneCompleto()
        {
            return DDD + Numero;
        }
    }
}
