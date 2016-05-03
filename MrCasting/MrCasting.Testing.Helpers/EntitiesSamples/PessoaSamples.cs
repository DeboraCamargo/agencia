using System;
using MrCasting.Domain.Entities;
using MrCasting.Domain.Enuns;
using MrCasting.Domain.DTO;

namespace MrCasting.Testing.Helpers.EntitiesSamples
{
    public class PessoaSamples
    {
        public const int ID_PADRAO = int.MaxValue;
        public const string NOME_SUCESSO = "Marcos";
        public const string SOBRENOME_SUCESSO = "Barbosa";
        public const Genero GENERO_PADRAO = Genero.Feminino;
        public static readonly DateTime DATA_NASCIMENTO_VALIDA = new DateTime(1989, 01, 07);
        public static readonly DateTime INCLUSAO_PADRAO = DateTime.Now.AddDays(-1);
        public static readonly DateTime ALTERACAO_PADRAO = DateTime.Now;


        public static Pessoa CreatePessoa()
        {
            return new Pessoa(NOME_SUCESSO, SOBRENOME_SUCESSO, DATA_NASCIMENTO_VALIDA
                            , CpfSamples.CriarCPFValido(), GENERO_PADRAO, ContatoSamples.CriarContatoValido())
            {
                DtInclusao = INCLUSAO_PADRAO,
                DtAlteracao = DateTime.Now,
                Id = ID_PADRAO,
            
            };
        }

        public static PessoaDTO CreatePessoaDTO()
        {
            return new PessoaDTO()
            {
                Nome = NOME_SUCESSO,
                Sobrenome = SOBRENOME_SUCESSO,
                DataNascimento = DATA_NASCIMENTO_VALIDA,
                Cpf = CpfSamples.CPF_VALIDO,
                Sexo = GENERO_PADRAO,
                Contato = ContatoSamples.CriarContatoDTOValido(),
                Id= ID_PADRAO
         
            };
        }

       
    }
}