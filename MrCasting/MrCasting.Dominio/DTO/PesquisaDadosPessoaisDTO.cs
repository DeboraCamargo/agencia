using MrCasting.Domain.Enuns;
using System;

namespace MrCasting.Domain.DTO
{
    public class PesquisaDadosPessoaisDTO
    {
        public Genero? Sexo { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public EnderecoDTO Endereco { get; set; }
    }
}