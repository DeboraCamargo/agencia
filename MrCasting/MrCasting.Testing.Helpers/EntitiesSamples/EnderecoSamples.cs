using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using MrCasting.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class EnderecoSamples
    {

        public const string LOGRADOURO_SUCESSO = "Avenida Celso Garcia";
        public const string COMPLEMENTO_SUCESSO = "AP 134 BL 18";
        public const string NUMERO_SUCESSO = "1907";
        public const string BAIRRO_SUCESSO = "Tatuapé";
        public const string CIDADE_SUCESSO = "São Paulo";
        public static readonly Uf UF = Uf.SP;
        public const int ID_SAMPLE = 9999;

        public static Endereco CriarEndereco()
        {
            return new Endereco(CIDADE_SUCESSO, UF)
            {
                Bairro = BAIRRO_SUCESSO,
                Complemento = COMPLEMENTO_SUCESSO,
                Id = ID_SAMPLE,
                Logradouro = LOGRADOURO_SUCESSO,
                Numero = NUMERO_SUCESSO,
                Cep = CEPSamples.CriarCEP()
            };
        }

        public static EnderecoDTO CriarEnderecoDTO()
        {
            return new EnderecoDTO()
            {
                Cidade = CIDADE_SUCESSO,
                Uf = UF,
                Bairro = BAIRRO_SUCESSO,
                Complemento = COMPLEMENTO_SUCESSO,
                Id = ID_SAMPLE,
                Logradouro = LOGRADOURO_SUCESSO,
                Numero = NUMERO_SUCESSO,
                Cep = CEPSamples.CEP_SAMPLES
            };
        }
    }
}
