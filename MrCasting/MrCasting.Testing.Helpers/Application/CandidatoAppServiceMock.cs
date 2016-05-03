using System;
using System.Collections.Generic;
using MrCasting.Domain.Entities;
using MrCasting.Testing.Helpers.EntitiesSamples;
using MrCasting.Domain.Interfaces.Application;
using MrCasting.Domain.DTO;
using MrCasting.Domain.DTO.Pesquisas;

namespace MrCasting.Services.WebApi.Test.Setup
{
    public class CandidatoAppServiceMock : ICandidatoAppService
    {
        public void Add(Candidato obj)
        {
            throw new NotImplementedException();
        }

        public void CadastrarCandidato(Candidato candidato)
        {
            //throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void EditarCandidato(Candidato candidato)
        {
            throw new NotImplementedException();
        }

        public void EditarCandidato(int idCandidato, Candidato candidato)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Candidato> GetAll()
        {
            throw new NotImplementedException();
        }

        public Candidato GetById(int id)
        {
            return CandidatoSamples.CreateCandidato(id);
        }

        public IEnumerable<Candidato> PesquisarCompleta(PesquisaCandidatoDTO pesquisaDadosPessoais)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Candidato> PesquisarPorDadosPessoais(PesquisaDadosPessoaisDTO pesquisaDadosPessoais)
        {
            throw new NotImplementedException();
        }

        public void Remove(Candidato obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Candidato obj)
        {
            throw new NotImplementedException();
        }
    }
}