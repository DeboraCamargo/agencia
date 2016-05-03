using MrCasting.Helpers;
using System;

namespace MrCasting.Domain.Entities
{
    public class Scouter : EntityBase
    {
        protected Scouter() { }

        public Scouter(int id, Pessoa dadosPessoaisScouter, string cnpj)
        {
            this.Id = id;
            this.DadosPessoais = dadosPessoaisScouter;
            this.Cnpj = cnpj;
            ValidaCNPJ(cnpj);
        }
        public string Cnpj { get; set; }
        public string Agencia { get; set; }
        public virtual Pessoa DadosPessoais { get; set; }

        #region Regras de negócio

        private void ValidaCNPJ(string cnpj)
        {
            Guard.ForNullOrEmpty(cnpj, "Cnpj Não pode ser nulo ou vazio");
            Guard.StringLength(cnpj, 13, 18, "Cnpj fora do tamanho esperado");
            Guard.ForContainSpace(cnpj, "Cnpj não pode conter espaços");

            bool valida = Guard.ValidaCnpj(cnpj);
            if (valida == false)
            {
                throw new Exception("CNPJ invalido");
            }
        }

        #endregion

    }
}
