using MrCasting.Domain.Entities;
using MrCasting.Domain.DTO;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class CandidatoSamples
    {
        public const string SOBRENOME_FANTASIA_CORRETO = "Do Violão";
        public const string NOME_FANTASIA_CORRETO = "Marcão";
        public const string REALISE_VALIDO_200_BYTES = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis et porttitor orci, quis laoreet elit. Nunc pretium non ante ac varius. In commodo, ex eu tincidunt posuere, metus ipsum vehicula volutpat. ";
        public const string REALISE_INVALIDO_1001_BYTES = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum pretium tellus id nunc ultricies, quis cursus elit imperdiet. Vestibulum sollicitudin tristique mi et mollis. Phasellus a laoreet nunc. Nunc mollis id nulla nec sollicitudin. Vivamus eget vestibulum eros. Ut tristique tempus porttitor. Proin in arcu vitae dui fringilla egestas. Donec vulputate feugiat suscipit. Pellentesque tincidunt urna ut fringilla molestie. Ut tempus felis sit amet ornare varius. In gravida tortor nec dui fermentum, sed accumsan neque pellentesque. Donec pharetra dui eu enim bibendum pulvinar. Proin a mollis mauris. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Fusce neque erat, accumsan nec nibh id, imperdiet euismod augue. Sed vitae lectus sed ex laoreet consectetur.Nullam eget risus eleifend, posuere nulla sit amet, feugiat ipsum.Donec eu erat condimentum, cursus leo ut, tincidunt urna. Vestibulum ante ipsum primis in faucibus orci luctus et metus.";

        public static Candidato CreateCandidato()
        {
            return CreateCandidato(1);
        }

        public static Candidato CreateCandidato(int id)
        {
            return new Candidato(PessoaSamples.CreatePessoa(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresse())
            {
                Id = id,
                SobrenomeFantasia = SOBRENOME_FANTASIA_CORRETO
            };
        }


        public static Candidato CreateCandidatoMinimo(int id)
        {
            return new Candidato(PessoaSamples.CreatePessoa(), NOME_FANTASIA_CORRETO, InteresseSamples.CreateInteresseAtor(0)) { Id = id };
        }

        public static CandidatoDTO CreateCandidatoMinimoDTO(int id)
        {
            return new CandidatoDTO()
            {
                DadosPessoais = PessoaSamples.CreatePessoaDTO(),
                NomeFantasia = NOME_FANTASIA_CORRETO,
                Interesse = InteresseSamples.CreateInteresseAtorDTO(0)
            };
        }

        public static CandidatoDTO CreateCandidatoDTO(int id)
        {
            return new CandidatoDTO()
            {
                Id = id,
                DadosPessoais = PessoaSamples.CreatePessoaDTO(),
                NomeFantasia = NOME_FANTASIA_CORRETO,
                SobrenomeFantasia = SOBRENOME_FANTASIA_CORRETO,
                DRT = "9808/SP",
                Nacionalidade = "Brasileira",
                Naturalidade = "Minas gerais",
                Profissao = "Engenheira",
                Realise = "Minha vida"

            };
        }
    }
}
