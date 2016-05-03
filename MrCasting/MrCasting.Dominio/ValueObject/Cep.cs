using MrCasting.Helpers;
using System;

namespace MrCasting.Domain.ValueObject
{
    public class Cep
    {
        public Int64 CepCod { get;  set; }
        public const int CepMaxLength = 8;

        protected Cep() { }

        public Cep(string cep)
        {
            ValidaCep(cep);
        }

        //TODO: esta com performance ruim - melhorar
        public Cep(Int64 cepCode)
        {
            ValidaCep(cepCode.ToString());
        }


        public string GetCepFormatado()
        {
            var cep = CepCod.ToString();

            while (cep.Length < 8)
                cep = "0" + cep;

            return cep.Substring(0, 5) + "-" + cep.Substring(5);
        }

        private void ValidaCep(string cep)
        {
            cep = TestHelper.GetNumeros(cep);
            Guard.StringLength("CEP", CepMaxLength, cep);
            try
            {
                CepCod = Convert.ToInt64(cep);
            }
            catch (Exception)
            {
                throw new Exception("Cep inválido: " + cep);
            }

        }
    }
}

