using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrCasting.Domain.Entities;
using MrCasting.Testing.Helpers.EntitiesSamples;
using MrCasting.Domain.DTO;
using MrCasting.Domain.ExtendionMethods;
using MrCasting.Domain.ValueObject;

namespace MrCasting.Domain.Tests.ExtendionMethods
{
    [TestClass]
    public class EntityDTOConverterTests
    {
        public EntityDTOConverterTests()
        {
        }

        #region Contato
        [TestMethod]
        public void EntityDTOConverter_WhenConvertingContatoToContatoDTO_ContatoEqualToContatoDTO()
        {
            Contato contato = ContatoSamples.CriarContatoValido();
            ContatoDTO contatoDTO = contato.ToContatoDTO();

            Assert.IsTrue(ContatoIgualContatoDTO(contato,contatoDTO));
        }

        [TestMethod]
        public void EntityDTOConverter_WhenConvertingContatoDTOToContato_ContatoDTOEqualToContato()
        {
            ContatoDTO contatoDTO = ContatoSamples.CriarContatoDTOValido();
            Contato contato = contatoDTO.ToContato();

            Assert.IsTrue(ContatoIgualContatoDTO(contato, contatoDTO));
        }

        #endregion

        #region Endereco

        [TestMethod]
        public void EntityDTOConverter_WhenConvertingEnderecoToEnderecoDTO_EnderecoEqualToEnderecoDTO()
        {
            Endereco endereco = EnderecoSamples.CriarEndereco();
            EnderecoDTO enderecoDTO = endereco.ToEnderecoDTO();

            Assert.IsTrue(EnderecoIgualEnderecoDTO(endereco, enderecoDTO));
        }

        [TestMethod]
        public void EntityDTOConverter_WhenConvertingEnderecoDTOToEndereco_EnderecoDTOEqualToEndereco()
        {
            EnderecoDTO enderecoDTO = EnderecoSamples.CriarEnderecoDTO();
            Endereco endereco = enderecoDTO.ToEndereco();
            endereco.Bairro = null;
            endereco.Cep = null;
            endereco.Complemento = null;
            endereco.Numero = null;
            endereco.Logradouro = null;

            Assert.IsTrue(EnderecoIgualEnderecoDTO(endereco, enderecoDTO));
        }

        [TestMethod]
        public void EntityDTOConverter_WhenConvertingEnderecoToEnderecoDTO_HavingNullTheOptionals_EnderecoEqualToEnderecoDTO()
        {
            Endereco endereco = EnderecoSamples.CriarEndereco();
            endereco.Bairro = null;
            endereco.Cep = null;
            endereco.Complemento = null;
            endereco.Numero = null;
            endereco.Logradouro = null;

            EnderecoDTO enderecoDTO = endereco.ToEnderecoDTO();
            

            Assert.IsTrue(EnderecoIgualEnderecoDTO(endereco, enderecoDTO));
        }

        [TestMethod]
        public void EntityDTOConverter_WhenConvertingEnderecoDTOToEndereco_HavingNullTheOptionals_EnderecoDTOEqualToEndereco()
        {
            EnderecoDTO enderecoDTO = EnderecoSamples.CriarEnderecoDTO();
            Endereco endereco = enderecoDTO.ToEndereco();
            endereco.Bairro = null;
            endereco.Cep = null;
            endereco.Complemento = null;
            endereco.Numero = null;
            endereco.Logradouro = null;

            Assert.IsTrue(EnderecoIgualEnderecoDTO(endereco, enderecoDTO));
        }

        #endregion


        [TestMethod]
        public void EntityDTOConverter_WhenConvertingPessoaToPessoaDTO_PessoaEqualToPessoaDTO()
        {
            Pessoa pessoa = PessoaSamples.CreatePessoa();
            PessoaDTO pessoaDTO = pessoa.ToPessoaDTO();

            Assert.IsTrue(PessoaIgualPessoaDTO(pessoa, pessoaDTO));
        }

        [TestMethod]
        public void EntityDTOConverter_WhenConvertingPessoaDTOToPessoa_PessoaDTOEqualToPessoa()
        {
            PessoaDTO pessoaDTO = PessoaSamples.CreatePessoaDTO();
            Pessoa pessoa = pessoaDTO.ToPessoa();

            Assert.IsTrue(PessoaIgualPessoaDTO(pessoa, pessoaDTO));
        }


        #region Auxiliares
        private static bool ContatoIgualContatoDTO(Contato contato, ContatoDTO contatoDTO)
        {
            Telefone telefoneFromDTO = new Telefone(contatoDTO.Telefone);
            if (contatoDTO.Email != contato.Email.EnderecoDeEmail)
                throw new Exception("Emails são diferentes");
            if(telefoneFromDTO.DDD != contato.Telefone.DDD)
                throw new Exception("DDD são diferentes");
            if(telefoneFromDTO.Numero !=  contato.Telefone.Numero)
                throw new Exception("Numeros de telefone são diferentes");
            return true;
        }

        private bool PessoaIgualPessoaDTO(Pessoa pessoa, PessoaDTO pessoaDTO)
        {
            if (pessoa == null && pessoaDTO == null)
                return true;

            if (pessoa.Nome != pessoaDTO.Nome)
                throw new Exception("Nome são diferentes");

            if (pessoa.SobreNome != pessoaDTO.Sobrenome)
                throw new Exception("Sobrenome são diferentes");

            if (pessoa.DataNascimento != pessoaDTO.DataNascimento)
                throw new Exception("DataNascimento são diferentes");

            if (pessoa.Cpf.Codigo != new Cpf(pessoaDTO.Cpf).Codigo)
                throw new Exception("Cpf são diferentes");

            //if (pessoa.Login != pessoaDTO.Login)
            //    throw new Exception("Login são diferentes");

            if (pessoa.Sexo != pessoaDTO.Sexo)
                throw new Exception("Sexo são diferentes");

            return ContatoIgualContatoDTO(pessoa.Contato, pessoaDTO.Contato) && EnderecoIgualEnderecoDTO(pessoa.Endereco,pessoaDTO.Endereco);
            
        }

        private bool EnderecoIgualEnderecoDTO(Endereco endereco, EnderecoDTO enderecoDTO)
        {
            if (endereco == null && enderecoDTO == null)
                return true;

            if (endereco.Id != enderecoDTO.Id)
                throw new Exception("Id são diferentes");

            if (endereco.Logradouro != enderecoDTO.Logradouro)
                throw new Exception("Logradouro são diferentes");

            if (endereco.Complemento != enderecoDTO.Complemento)
                throw new Exception("Complemento são diferentes");

            if (endereco.Numero != enderecoDTO.Numero)
                throw new Exception("Numero são diferentes");

            if (endereco.Bairro != enderecoDTO.Bairro)
                throw new Exception("Bairro são diferentes");

            if (endereco.Cidade != enderecoDTO.Cidade)
                throw new Exception("Cidade são diferentes");

            if (endereco.Uf != enderecoDTO.Uf)
                throw new Exception("Uf são diferentes");

            if (endereco.Cep != null && enderecoDTO.Cep != null && endereco.Cep.CepCod != new Cep(enderecoDTO.Cep).CepCod)
                throw new Exception("Cep são diferentes");

            return true;
        }
        #endregion
    }
}
